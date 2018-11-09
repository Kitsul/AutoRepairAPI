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

        //public DbSet<Appoimtment> Appoimtments { get; set; }
        //public DbSet<User> Users { get; set; }
        //public DbSet<ModelCar> ModelsCar { get; set; }
        public DbSet<ServiceType> ServicesType { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDiscountService>()
            .HasKey(udc => new { udc.UserId, udc.DiscountId, udc.ServiceTypeId });

            modelBuilder.Entity<UserDiscountService>()
                .HasOne(udc => udc.User)
                .WithMany(user => user.UserDiscountServices)
                .HasForeignKey(udc => udc.UserId);

            modelBuilder.Entity<UserDiscountService>()
                .HasOne(udc => udc.Discount)
                .WithMany(d => d.UserDiscountServices)
                .HasForeignKey(udc => udc.DiscountId);

            modelBuilder.Entity<UserDiscountService>()
                .HasOne(udc => udc.ServiceType)
                .WithMany(st => st.UserDiscountServices)
                .HasForeignKey(udc => udc.ServiceTypeId);

            modelBuilder.Entity<ServiceType>().HasData(
                new ServiceType()
                {
                    Id = Guid.Parse("486A78D8-436B-4639-B430-D22C52D30D28"),
                    Name = "Transmission"

                },
                new ServiceType()
                {
                    Id = Guid.Parse("4EB72F18-E001-4F70-BC4B-023F56484A2D"),
                    Name = "Vehicle Maintenance"

                },
                new ServiceType()
                {
                    Id = Guid.Parse("34708881-01E2-461E-8312-1EA08125A3FD"),
                    Name = "Vehicle Rapair"

                },
                new ServiceType()
                {
                    Id = Guid.Parse("DEF06207-4729-4CBB-8895-C7F0C3AFA53D"),
                    Name = "Other"

                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
