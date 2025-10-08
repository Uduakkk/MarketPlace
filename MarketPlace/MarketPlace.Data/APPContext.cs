using MarketPlace.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace MarketPlace.Data
{
    public class APPContext : DbContext
    {
        public APPContext(DbContextOptions<APPContext> options)
       : base(options)
        {
        }


        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Cart> Carts { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Notification> Notifications { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }






        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            FilterQuery(builder);
            IndexFields(builder);
            //  builder.Seed();
        }
        private void IndexFields(ModelBuilder builder)
        {
          //  builder.Entity<AppUser>().HasIndex(x => x.Email).IsUnique();

            //   builder.Entity<RequestApproval>().HasIndex(x => new { x.RequestID, x.DesignationId }).IsUnique();

        }
        private void FilterQuery(ModelBuilder builder)
        {

        }
    }
}
