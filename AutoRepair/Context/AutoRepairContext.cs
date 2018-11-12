using AutoRepair.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection.Emit;

namespace AutoRepair.Context
{
    public class AutoRepairContext : DbContext
    {
        public AutoRepairContext(DbContextOptions<AutoRepairContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<Appoimtment> Appoimtments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ModelCar> ModelsCar { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<AppoimtmentServiceType> AppoimtmentServiceType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDiscount>()
            .HasKey(udc => new { udc.UserId, udc.DiscountId});

            modelBuilder.Entity<UserDiscount>()
                .HasOne(ud => ud.User)
                .WithMany(user => user.UserDiscount)
                .HasForeignKey(udc => udc.UserId);

            modelBuilder.Entity<UserDiscount>()
                .HasOne(ud => ud.Discount)
                .WithMany(d => d.UserDiscount)
                .HasForeignKey(ud => ud.DiscountId);

            modelBuilder.Entity<Discount>().HasData(
                new Discount()
                {
                    Id =1,
                    Count = 10.00m,
                    Description = "Normal",
                },
                new Discount()
                {
                    Id = 2,
                    Count = 20.00m,
                    Description = "Gold",
                },
                new Discount()
                {
                    Id = 3,
                    Count = 50.00m,
                    Description = "Premium",
                });
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = 1,
                    FirstName = "Bill",
                    SecondName = "Gates",
                    Email = "bill_gates@gmail.com",
                    PhoneNumber = "+1-202-555-0192"
                },
                new User()
                {
                    Id = 2,
                    FirstName = "Steve",
                    SecondName = "Jobs",
                    Email = "steve_jobs@gmail.com",
                    PhoneNumber = "+1-202-555-0186"
                });

            modelBuilder.Entity<ModelCar>().HasData(
                new ModelCar()
                {
                    Id = 1,
                    Name = "Audi",
                },
                new ModelCar()
                {
                    Id = 2,
                    Name = "BMW"
                },
                new ModelCar()
                {
                    Id = 3,
                    Name = "Honda"
                },
                new ModelCar()
                {
                    Id = 4,
                    Name = "Mersedes-Benz"
                },
                new ModelCar()
                {
                    Id = 5,
                    Name = "Volkswagen"
                });
            modelBuilder.Entity<UserDiscount>().HasData(
                new UserDiscount()
                {
                    UserId = 1,
                    DiscountId = 2
                },
                 new UserDiscount()
                 {
                     UserId = 1,
                     DiscountId = 1
                 },
                new UserDiscount()
                {
                    UserId = 2,
                    DiscountId = 1
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
