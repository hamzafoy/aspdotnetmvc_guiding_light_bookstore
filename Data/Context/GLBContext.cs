using Microsoft.EntityFrameworkCore;
using SampleNetCoreMVC.Data.Entities;

namespace SampleNetCoreMVC.Data.Context
{
    public class GLBContext : DbContext
    {
        private readonly IConfiguration _config;

        public GLBContext(IConfiguration config)
        {
            _config = config;
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer(_config["ConnectionStrings:GLBContextDb"]);
        }
    }
}
