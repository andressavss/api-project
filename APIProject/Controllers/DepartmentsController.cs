using APIProject.Context;
using APIProject.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace APIProject.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class DepartmentsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public DepartmentsController(AppDbContext context)
        {
            _context = context;
        }

        [HttpGet("Products")]
        public ActionResult<IEnumerable<Department>> GetDepartmentsAndProducts()
        {
            return _context.Departments.Include(p => p.Products).ToList();
        }

        [HttpGet]
        public ActionResult<IEnumerable<Department>> Get()
        {
            var departments = _context.Departments.ToList();

            if (departments == null)
            {
                return NotFound("Department not found");
            }

            return Ok(departments);
        }

        [HttpGet("{id:int}", Name = "GetDepartment")]
        public ActionResult<Department> Get(int id)
        {
            var department = _context.Departments.FirstOrDefault(p => p.DepartmentId == id);

            if (department == null)
            {
                return NotFound("Department not found");
            }

            return Ok(department);
        }

        [HttpPost]
        public ActionResult Post(Department department)
        {
            if (department == null)
            {
                return BadRequest("Department is null");
            }

            _context.Departments.Add(department);
            _context.SaveChanges();

            return new CreatedAtRouteResult("GetDepartment",
                new { id = department.DepartmentId }, department);
        }

        [HttpPut("{id:int}")]
        public ActionResult Put(int id, Department department)
        {
            if (id != department.DepartmentId)
            {
                return BadRequest("Departments are not equal");
            }

            _context.Entry(department).State = EntityState.Modified;
            _context.SaveChanges();

            return Ok(department);
        }

        [HttpDelete]
        public ActionResult Delete(int id)
        {
            var department = _context.Departments.FirstOrDefault(p => p.DepartmentId == id);

            if (department == null)
            {
                return NotFound("Department not found");
            }

            _context.Departments.Remove(department);
            _context.SaveChanges();

            return Ok(department);
        }
    }
}
