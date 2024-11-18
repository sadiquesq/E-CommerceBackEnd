using E_Commerce.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;

namespace E_Commerce.Controllers
{
    public class MainDbContext : DbContext
    {

        public MainDbContext(DbContextOptions<MainDbContext> options) : base(options) { }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.ConfigureWarnings(warnings => warnings.Ignore(RelationalEventId.PendingModelChangesWarning));
        }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> carts { get; set; }
        public DbSet<Order> Orders { get; set; }

        public DbSet<WhishList> WhishList { get; set; }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //User


            modelBuilder.Entity<User>()
                .HasKey(e => e.UserId);
            modelBuilder.Entity<User>().HasData(new List<User> {
                new User
                {
                    UserId = Guid.Parse("a1f5d5da-e94d-44f1-a8c3-b60f42101a01"),
                    UserName = "Admin",
                    Email = "admin@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("12345678"),
                    Role = "Admin",
                    IsBlock = true,
                    CreatedDate = new DateTime(2024, 1, 1)  
                },
                new User
                {
                    UserId = Guid.Parse("e5b7d7f4-23f5-4d5f-bd85-dba98b93723b"),
                    UserName = "Admin1",
                    Email = "admin1@gmail.com",
                    Password = BCrypt.Net.BCrypt.HashPassword("12345678aa"),
                    Role = "Admin",
                    IsBlock = true,
                    CreatedDate = new DateTime(2024, 1, 1)  
                }
            });

            modelBuilder.Entity<User>()
                .HasOne(e => e.Cart)
                .WithOne(e => e.User)
                .HasForeignKey<Cart>(e => e.UserId);


            //Category

            modelBuilder.Entity<Category>()
                .HasKey(e => e.CategoryId);

           



            //Product

            modelBuilder.Entity<Product>()
                .HasKey(e => e.ProductId);
            modelBuilder.Entity<Product>()
              .Property(e => e.Price)
              .HasPrecision(18, 2);
           modelBuilder.Entity<Product>()
                .HasOne(e =>e.Category)
                .WithMany(e =>e.Products)
                .HasForeignKey(e => e.CategoryId);


            //Cart

            modelBuilder.Entity<Cart>()
                .HasKey(e => e.CartId);
            modelBuilder.Entity<Cart>()
              .Property(e => e.TotalAmount)
              .HasPrecision(18, 2);


            //cartitem

            modelBuilder.Entity<CartItem>()
                .HasKey(e => e.CartItemId);



            //order

            modelBuilder.Entity<Order>()
                .HasKey(e => e.OrderId);
            modelBuilder.Entity<Order>()
                .Property(e => e.TotalAmount)
                .HasPrecision(18, 2);







        }

    }
}
