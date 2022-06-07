using EmployeeRecordSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeRecordSystem
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employee { get; set; }
    }
}
