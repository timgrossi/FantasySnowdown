using Microsoft.EntityFrameworkCore;
 
namespace FantasySnowdown.Models
{
    public class FantasyContext : DbContext
    {
        public FantasyContext(DbContextOptions<FantasyContext> options) : base(options) { }
        public DbSet<User> Users {get;set;}

        public DbSet<Player> Players {get;set;}

        public DbSet<Team> Teams {get;set;}
        public DbSet<Draft> Drafts {get;set;}

        public DbSet<JoinDraft> JoinDrafts {get;set;}

    }
}