using AutoRepair.Entities;
using Microsoft.EntityFrameworkCore;


namespace AutoRepair.Context
{
    public class AppoimtmentsContext : DbContext
    {
        public AppoimtmentsContext(DbContextOptions<AppoimtmentsContext> options):base(options)
        {

        }

        public DbSet<Appoimtment> Appoimtments { get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<ModelCar> ModelsCar { get; set; }
        public DbSet<ServiceType> ServicesType { get; set; }
        


    }
}
