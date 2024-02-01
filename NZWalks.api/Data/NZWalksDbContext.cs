using Microsoft.EntityFrameworkCore;
using nzwalks.api.Models.Domains;

namespace nzwalks.api.Data
{
    public class NZWalksDbContext :DbContext
    {
        public NZWalksDbContext(DbContextOptions dbContextoptions):base(dbContextoptions)
        {
                
        }

        public DbSet<Difficulty> Difficulties { get; set; }

        public DbSet<Region> Regions { get; set; }

        public DbSet<Walk> Walks { get; set; }
    }
}
