using Microsoft.EntityFrameworkCore;
using SampleNetCoreMVC.Data.Entities;

namespace SampleNetCoreMVC.Data.Context
{
    public class GLBContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Checkout> Checkouts { get; set; }
    }
}
