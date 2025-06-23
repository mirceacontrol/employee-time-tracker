using Microsoft.EntityFrameworkCore;
using EmployeeTimeTracker.Models;

namespace EmployeeTimeTracker.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Employee> Employees => Set<Employee>();
        public DbSet<WorkSession> WorkSessions => Set<WorkSession>();
        public DbSet<Holiday> Holidays => Set<Holiday>();
    }
}
