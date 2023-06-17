using Microsoft.EntityFrameworkCore;
using mvcgitexample.Models;

namespace mvcgitexample.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base(options)  
        {

        }

        public DbSet<User> Users { get; set; }
    }
}
