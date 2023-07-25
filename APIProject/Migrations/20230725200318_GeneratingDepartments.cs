using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace APIProject.Migrations
{
    /// <inheritdoc />
    public partial class GeneratingDepartments : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Insert into Departments(Name) Values('Electronics')");
            migrationBuilder.Sql("Insert into Departments(Name) Values('Books')");
            migrationBuilder.Sql("Insert into Departments(Name) Values('Pets')");
            migrationBuilder.Sql("Insert into Departments(Name) Values('Beauty')");
            migrationBuilder.Sql("Insert into Departments(Name) Values('Sports')");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("Delete from Departments");
        }
    }
}
