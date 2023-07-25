using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProject.Migrations
{
    /// <inheritdoc />
    public partial class GeneratingProducts : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId) " +
               "Values('Smart TV','Smart TV 50 QLED 4K',1300.00,now(),1)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
                + "Values('Laptop','Laptop 8GB Memory',999.99,now(),1)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
                + "Values('Clean Code','A Handbook of Agile Software',40.00,now(),2)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
               + "Values('A Game of Thrones','A Song of Ice and Fire Book 1',15.99,now(),2)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
               + "Values('Pet Collar','Pet Collar with Metal',8.99,now(),3)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
               + "Values('Cat Water Fountain','Automatic Cat Water Fountain',26.99,now(),3)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
               + "Values('Foundation','Foundation Full Coverage',39.99,now(),4)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
               + "Values('Concealer','Concealer Soft Matte',20.99,now(),4)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
               + "Values('Ball','Soccer Ball',6.99,now(),5)");
            migrationBuilder.Sql("Insert into Products(Name, Description, Price, RegistrationDate, DepartmentId)"
              + "Values('Ball Pump','Portable Air Pump',18.99,now(),5)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Products");
        }
    }
}
