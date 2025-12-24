using SolbergBakery2531.DAL.Model;
using System.Data.Entity;

namespace SolbergBakery2531.DAL.Data
{
    public class BakeryDbContext : DbContext
    {
        //Dataset
        public DbSet<User> Users { get; set; }
        public DbSet<Staff> Staffs { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductVisual> ProductVisuals { get; set; }
        //public DbSet<ProductOpt> ProductOtps { get; set; }
        public DbSet<StaffHistory> StaffHistories { get; set; }
        public DbSet<ProductHistory> ProductHistories { get; set; }
        public DbSet<ProdCategory> ProdCategories { get; set; }
        public BakeryDbContext(string connectionString) : base(connectionString)
        {
            // Constructor for the DAL to receive a specific connection string if I really wanted to, or needed to use multiple DBs.
        }
        public BakeryDbContext() : base("BakeryConnectionString")
        {
        }
        //FluentAPI [on demand]
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Staff>()
                .HasOptional(s => s.StaffAccount) 
                .WithRequired(u => u.AccociatedStaff);// User must have a Staff parent
                // Staff exists first, might not have account (1-0..1 relationship that I did a presentation on in WebDev class Week 4 "EF")
            base.OnModelCreating(modelBuilder);
        }
    }
}