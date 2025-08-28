using CRUDMVCProject.Models;
using Microsoft.EntityFrameworkCore;

namespace CRUDMVCProject.Data
{
    public class ApplicationContext : DbContext
    {
        internal readonly object Employees;

        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Employee> detail { get; set; }
        //public object Employee { get; internal set; }
    }
}
