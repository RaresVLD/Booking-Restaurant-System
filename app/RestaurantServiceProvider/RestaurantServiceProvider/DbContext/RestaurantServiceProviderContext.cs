using System;
using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;

namespace RestaurantServiceProvider
{
    public class RestaurantServiceProviderContext : DbContext
    {
        public RestaurantServiceProviderContext()
        {
            Database.EnsureCreated();
        }

        public DbSet<Command> Commands { get; set; }
        public DbSet<Menu> Menus { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<User> Users { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost,1432; Database=RestaurantServiceProvider; User=SA; Password=reallyStrongPwd123");
            }
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Command>().HasKey(c => c.Id);
            modelBuilder.Entity<Menu>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().HasKey(c => c.Id);
            modelBuilder.Entity<Reservation>().HasKey(c => c.Id);
            modelBuilder.Entity<Restaurant>().HasKey(c => c.Id);
            modelBuilder.Entity<User>().HasKey(c => c.Id);


        }
    }
} 
