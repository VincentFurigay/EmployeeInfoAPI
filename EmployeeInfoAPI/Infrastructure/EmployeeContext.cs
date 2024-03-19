using EmployeeInfoAPI.Domain;
using Microsoft.EntityFrameworkCore;

namespace EmployeeInfoAPI.Infrastructure
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<EmployeeInformation> EmployeeInformations { get; set; }
    }
}
