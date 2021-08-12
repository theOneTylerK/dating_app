using Microsoft.EntityFrameworkCore;
using API.Entites;

namespace API.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions options) : base(options)
        {   
        }

        public DbSet<AppUser> Users { get; set; }
    }
}