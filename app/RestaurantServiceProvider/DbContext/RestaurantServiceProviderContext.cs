﻿using Microsoft.EntityFrameworkCore;
using RestaurantServiceProvider.Entities;
using RestaurantServiceProvider.Utils;

namespace RestaurantServiceProvider
{
    public class RestaurantServiceProviderContext : DbContext
    {
        public RestaurantServiceProviderContext(DbContextOptions<RestaurantServiceProviderContext> options) : base(options)
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
            /*
            if (!optionsBuilder.IsConfigured)
            {

                optionsBuilder.UseSqlServer("Server=localhost,1432; Database=RestaurantService; User=SA; Password=reallyStrongPwd123");
            }
            */
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Command>().HasKey(c => c.Id);
            modelBuilder.Entity<Menu>().HasKey(c => c.Id);
            modelBuilder.Entity<Product>().HasKey(c => c.Id);
            modelBuilder.Entity<Reservation>().HasKey(c => c.Id);
            modelBuilder.Entity<Restaurant>().HasKey(c => c.Id);
            modelBuilder.Entity<User>().HasKey(c => c.Id);

            modelBuilder.Entity<Restaurant>().HasData(
                RestaurantSeed.CreateRestaurants());

            modelBuilder.Entity<Menu>().HasData(
               MenuSeed.CreateMenus());

            modelBuilder.Entity<Product>().HasData(
                ProductSeed.CreateProducts());
            modelBuilder.Entity<User>().HasData(
                UserSeed.CreateUsers());
            modelBuilder.Entity<Reservation>().HasData(
                ReservationSeed.CreateReservations());
            modelBuilder.Entity<Command>().HasData(
                CommandSeed.CreateCommands());
        }
    }
} 