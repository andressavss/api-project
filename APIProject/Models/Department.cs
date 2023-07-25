using System.Collections.ObjectModel;

namespace APIProject.Models
{
    public class Department
    {
        public int DepartmentId { get; set; }
        public string? Name { get; set; }
        public ICollection<Product> Products { get; set; }

        public Department()
        {
            Products = new Collection<Product>();
        }
    }
}
