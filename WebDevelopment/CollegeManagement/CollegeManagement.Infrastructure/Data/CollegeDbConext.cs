using CollegeManagement.Web.Models;
using Microsoft.EntityFrameworkCore;

namespace CollegeManagement.Web.Data;
public class CollegeDbConext: DbContext
{
    public DbSet<Student> Students { get; set; }
    public DbSet<Major> Majors { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Employee> Employees { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=CollegeDb;Integrated Security=True;");
    }
}
