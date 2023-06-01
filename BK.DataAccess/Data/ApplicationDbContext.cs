using System;
using System.Reflection.Emit;
using BK.Models;
using BK.Utility;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BK.DataAccess.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Ad> Ads { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<CarSpecification> CarSpecifications { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Ad>().HasData(
                new Ad { Id = 1, CarId = 1, Status = SD.Status_Approved, CreatedAt = DateTime.Now },
                new Ad { Id = 2, CarId = 2, Status = SD.Status_Pending, CreatedAt = DateTime.Now },
                new Ad { Id = 3, CarId = 3, Status = SD.Status_Approved, CreatedAt = DateTime.Now }
                );


            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    OwnerId = 1,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    Brand = "Audi",
                    Model = "A6",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Manuel",
                    Mileage = 3321,
                    SalePrice = 30000,
                    CarSpecificationId = 1,
                    Images = ""
                },
                new Car
                {
                    Id = 2,
                    OwnerId = 5,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    Brand = "Audi",
                    Model = "A6",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Manuel",
                    Mileage = 3321,
                    SalePrice = 30000,
                    CarSpecificationId = 2,
                    Images = ""
                },
                new Car
                {
                    Id = 3,
                    OwnerId = 4,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    Brand = "Audi",
                    Model = "A6",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Manuel",
                    Mileage = 3321,
                    SalePrice = 30000,
                    CarSpecificationId = 3,
                    Images = ""
                },
                new Car
                {
                    Id = 4,
                    OwnerId = 2,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    Brand = "Audi",
                    Model = "A5",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Manuel",
                    Mileage = 3321,
                    SalePrice = 30000,
                    CarSpecificationId = 4,
                    Images = ""
                },
                new Car
                {
                    Id = 5,
                    OwnerId = 1,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    Brand = "Audi",
                    Model = "A7",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Automatic",
                    Mileage = 33221,
                    SalePrice = 30000,
                    CarSpecificationId = 5,
                    Images = ""
                }
                );


            modelBuilder.Entity<CarSpecification>().HasData(
                new CarSpecification
                {
                    Id = 1,
                    SpecificationName = "Camera"
                },
                new CarSpecification
                {
                    Id = 2,
                    SpecificationName = "Seat heat"
                },
                new CarSpecification
                {
                    Id = 3,
                    SpecificationName = "Autonom drive"
                },
                new CarSpecification
                {
                    Id = 4,
                    SpecificationName = "Navigation"
                },
                new CarSpecification
                {
                    Id = 5,
                    SpecificationName = "Camera"
                }
                );
        }
    }
}

