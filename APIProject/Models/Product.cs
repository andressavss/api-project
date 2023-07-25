namespace APIProject.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public DateTime RegistrationDate { get; set; }
        public int DepartmentId { get; set; }
        public Department Departments { get; set; }
    }
}
