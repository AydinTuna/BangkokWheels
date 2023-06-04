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
            modelBuilder.Entity<ApplicationUser>().ToTable("Owner");
            modelBuilder.Entity<ApplicationUser>().Property(u => u.Id).HasColumnName("OwnerId");

            modelBuilder.Entity<Car>()
                .HasOne(c => c.Owner)
                .WithMany(u => u.Cars)
                .HasForeignKey(c => c.OwnerId)
                .IsRequired();


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
                },
                new Brand
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

