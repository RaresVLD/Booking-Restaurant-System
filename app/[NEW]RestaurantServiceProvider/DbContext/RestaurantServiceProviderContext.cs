using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.Utils;
namespace RestaurantServiceProvider
{
    public class RestaurantServiceProviderContext : DbContext
    {
        public DbSet<User> Users { set; get; }
        public DbSet<Restaurant> Restaurants { set; get; }
        public DbSet<Product> Products{ set; get; }
        public DbSet<Booking> Bookings { set; get; }

        public RestaurantServiceProviderContext(DbContextOptions<RestaurantServiceProviderContext> options) : base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Restaurant_DBNewFinal;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            User[] users = UserSeed.CreateUsers();
            Restaurant[] restaurants = RestaurantSeed.CreateRestaurants();
            Product[] products = ProductSeed.CreateProducts(restaurants);
            Booking[] bookings = BookingSeed.CreateBookings(users, restaurants, products);

            modelBuilder.Entity<Restaurant>().HasMany(r => r.Products).WithOne(p => p.Restaurant);
            modelBuilder.Entity<Product>().HasOne(p => p.Restaurant).WithMany(r => r.Products);
            modelBuilder.Entity<User>().HasMany(u => u.Bookings).WithOne(b => b.User);
            modelBuilder.Entity<Booking>().HasOne(b => b.User).WithMany(u => u.Bookings);
            modelBuilder.Entity<Booking>().HasMany(b => b.Products);
            modelBuilder.Entity<Product>().HasMany(b => b.Bookings);



            modelBuilder.Entity<User>().HasData(users);
            modelBuilder.Entity<Restaurant>().HasData(restaurants);
            modelBuilder.Entity<Product>().HasData(products);
            modelBuilder.Entity<Booking>().HasData(bookings);
       
        }

    }
}
