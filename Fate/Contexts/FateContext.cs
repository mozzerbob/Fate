using Fate.Models;
using Microsoft.EntityFrameworkCore;

namespace Fate.Contexts
{
    public class FateContext : DbContext
    {
        public FateContext(DbContextOptions<FateContext> options) : base(options)
        {

        }
            
        public DbSet<Aspect> Aspects { get; set; }
        public DbSet<Enviroment> Enviroments { get; set; }
        public DbSet<Player> Players { get; set; }
        public DbSet<Story> Stories { get; set; }
    }
}
