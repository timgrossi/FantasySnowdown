using Microsoft.EntityFrameworkCore;
 
namespace FantasySnowdown.Models
{
    public class FantasyContext : DbContext
    {
        public FantasyContext(DbContextOptions<FantasyContext> options) : base(options) { }
        public DbSet<User> Users {get;set;}
    }
}