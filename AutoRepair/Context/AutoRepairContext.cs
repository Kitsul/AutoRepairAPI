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
        public DbSet<ServiceType> ServicesType { get; set; }
        public DbSet<Discount> Discounts { get; set; }

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
            modelBuilder.Entity<Discount>().HasData(
                new Discount()
                {
                    Id = Guid.Parse("5AF3AA07-F053-4A0A-BD12-06D24367584E"),
                    Count = 10.00m,
                    Description = "Normal",
                },
                new Discount()
                {
                    Id = Guid.Parse("456DA559-3F64-402F-8997-E5F86B884AA3"),
                    Count = 20.00m,
                    Description = "Gold",
                },
                new Discount()
                {
                    Id = Guid.Parse("0C15B1CE-7F03-472C-A3AB-8C4507C1DBEA"),
                    Count = 50.00m,
                    Description = "Premium",
                });
            modelBuilder.Entity<User>().HasData(
                new User()
                {
                    Id = Guid.Parse("A1F0630A-3845-4E3C-B4EF-8468B9E0BFC1"),
                    FirstName = "Bill",
                    SecondName = "Gates",
                    Email = "bill_gates@gmail.com",
                    PhoneNumber = "+1-202-555-0192"
                },
                new User()
                {
                    Id = Guid.Parse("0AC4A250-65FC-43E3-88EB-603716013BC5"),
                    FirstName = "Steve",
                    SecondName = "Jobs",
                    Email = "steve_jobs@gmail.com",
                    PhoneNumber = "+1-202-555-0186"
                });

            modelBuilder.Entity<ModelCar>().HasData(
                new ModelCar()
                {
                    Id = Guid.Parse("7F1A947C-DFE4-4B16-8162-2E196921CF61"),
                    Name = "Audi",
                },
                new ModelCar()
                {
                    Id = Guid.Parse("1A879D29-5F6B-4E4D-8BF6-F2D1245FC979"),
                    Name = "BMW"
                },
                new ModelCar()
                {
                    Id = Guid.Parse("459B8836-ACE8-4249-8809-97EBEC8BBB68"),
                    Name = "Honda"
                },
                new ModelCar()
                {
                    Id = Guid.Parse("2B23140A-0186-40E7-980C-2143B5EC6635"),
                    Name = "Mersedes-Benz"
                },
                new ModelCar()
                {
                    Id = Guid.Parse("0A6535AE-DF9F-4D71-8A95-7B513CF93C83"),
                    Name = "Volkswagen"
                });
            modelBuilder.Entity<UserDiscountService>().HasData(
                new UserDiscountService()
                {
                    UserId = Guid.Parse("A1F0630A-3845-4E3C-B4EF-8468B9E0BFC1"),
                    DiscountId = Guid.Parse("456DA559-3F64-402F-8997-E5F86B884AA3"),
                    ServiceTypeId = Guid.Parse("4EB72F18-E001-4F70-BC4B-023F56484A2D")
                },
                 new UserDiscountService()
                 {
                     UserId = Guid.Parse("A1F0630A-3845-4E3C-B4EF-8468B9E0BFC1"),
                     DiscountId = Guid.Parse("5AF3AA07-F053-4A0A-BD12-06D24367584E"),
                     ServiceTypeId = Guid.Parse("34708881-01E2-461E-8312-1EA08125A3FD")
                 },
                new UserDiscountService()
                {
                    UserId = Guid.Parse("0AC4A250-65FC-43E3-88EB-603716013BC5"),
                    DiscountId = Guid.Parse("0C15B1CE-7F03-472C-A3AB-8C4507C1DBEA"),
                    ServiceTypeId = Guid.Parse("486A78D8-436B-4639-B430-D22C52D30D28")
                });

            base.OnModelCreating(modelBuilder);
        }

    }
}
