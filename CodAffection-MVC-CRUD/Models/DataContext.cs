using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;

namespace CodAffection_MVC_CRUD.Models
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> dbContextOption) : base(dbContextOption) { }

        public DbSet<Employee> Employees { get; set; }

    }
}
