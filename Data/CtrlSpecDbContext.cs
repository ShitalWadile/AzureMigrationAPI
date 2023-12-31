using ctrlspec.Models;
using Microsoft.EntityFrameworkCore;

namespace ctrlspec.Data
{
    public class CtrlSpecDbContext:DbContext
    {
        public CtrlSpecDbContext(DbContextOptions<CtrlSpecDbContext>options):base(options)
        {

        }

      

        public DbSet<Login> login { get; set; }
         public DbSet<ServerList> ServerLists { get; set; }
         public DbSet<ApplicationList> ApplicationLists { get; set; }
        public DbSet<Application> Applications { get; set; }
        

    }
}
