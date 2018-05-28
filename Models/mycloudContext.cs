using Microsoft.EntityFrameworkCore;
using mycloud.Models;

namespace mycloud.Models
{
    public class mycloudContext : DbContext
    {
        public DbSet<Insulator> Insulators { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Conductor> Conductors { get; set; }

        public DbSet<Design> Designs { get; set; }

        public DbSet<Restriction> Restrictions { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<CableRange> CableRanges { get; set; }
        public DbSet<CprClass> CprClasses { get; set; }
        public DbSet<VoltageClass> VoltageClasses { get; set; }
        public DbSet<Installation1> Installation1s { get; set; }
        public DbSet<Installation2> Installation2s { get; set; }
        public DbSet<Installation3> Installation3s { get; set; }
        public DbSet<LinkCableInstallation> LinkCableInstallations { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseMySQL("server=localhost;database=myclouddb;user=root;password=Password01;SslMode=none");
            
            //optionsBuilder.UseSqlServer(@"Server=.\;Database=EFCoreWebDemo;Trusted_Connection=True;MultipleActiveResultSets=true");
        }
    }
}