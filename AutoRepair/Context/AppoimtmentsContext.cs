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
        
    }
}
