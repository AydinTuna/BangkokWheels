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

        public DbSet<Car> Cars { get; set; }
        public DbSet<CarSpecification> CarSpecifications { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<Brand> Brands { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);



            modelBuilder.Entity<Car>().HasData(
                new Car
                {
                    Id = 1,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    BrandId = 1,
                    Model = "A6",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Manuel",
                    Mileage = 3321,
                    SalePrice = 30000,
                    CarSpecificationId = 1,
                    ImageUrl = "https://cdn1.ntv.com.tr/gorsel/-UbLpLawtEG71qP298GB3g.jpg?width=952&height=540&mode=both&scale=both",
                    Status = SD.Status_Approved,
                    CreatedAt = DateTime.Now,
                    AdTitle = "Harika bir araba",
                    AdDescription = "Harika bir araba ulan"
                },
                new Car
                {
                    Id = 2,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    BrandId = 1,
                    Model = "A6",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Manuel",
                    Mileage = 3321,
                    SalePrice = 30000,
                    CarSpecificationId = 2,
                    ImageUrl = "https://cdn1.ntv.com.tr/gorsel/-UbLpLawtEG71qP298GB3g.jpg?width=952&height=540&mode=both&scale=both",
                    Status = SD.Status_Approved,
                    CreatedAt = DateTime.Now,
                    AdTitle = "Harika bir araba",
                    AdDescription = "Harika bir araba ulan"
                },
                new Car
                {
                    Id = 3,
                    Type = "Sedan",
                    ProductionYear = 2000,
                    BrandId = 1,
                    Model = "A6",
                    FuelType = "Diesel",
                    Engine = "v6",
                    Transmission = "Manuel",
                    Mileage = 3321,
                    SalePrice = 30000,
                    CarSpecificationId = 3,
                    ImageUrl = "https://cdn1.ntv.com.tr/gorsel/-UbLpLawtEG71qP298GB3g.jpg?width=952&height=540&mode=both&scale=both",
                    Status = SD.Status_Approved,
                    CreatedAt = DateTime.Now,
                    AdTitle = "Harika bir araba",
                    AdDescription = "Harika bir araba ulan"
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

            modelBuilder.Entity<Brand>().HasData(
                new Brand
                {
                    Id = 1,
                    BrandName = "Audi"
                },
                new Brand
                {
                    Id = 2,
                    BrandName = "BMW"
                }, new Brand
                {
                    Id = 3,
                    BrandName = "Mercedes"
                },
                new Brand
                {
                    Id = 4,
                    BrandName = "Ford"
                },
                new Brand
                {
                    Id = 5,
                    BrandName = "Mitsubishi"
                },
                new Brand
                {
                    Id = 6,
                    BrandName = "Nissan"
                }

                );
        }
    }
}

