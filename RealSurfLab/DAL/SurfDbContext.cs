using RealSurfLab.Models.DBModels;
using System.Data.Entity;

namespace RealSurfLab.DAL
{
    public class SurfDbContext : DbContext
    {

        static SurfDbContext()
        {
            Database.SetInitializer(new SurfDbInitializer());
        }

        public SurfDbContext() : base("RealSurfDatabase")
        { }

        public DbSet<User> Users { get; set; }

        public DbSet<Post> Posts { get; set; }

    }
}