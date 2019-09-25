
using Microsoft.EntityFrameworkCore;
using RapiSolverWeb.Models;

namespace Hospital.Repositoy.dbcontext {
    public class ApplicationDbContext : DbContext {
        public DbSet<Customer> customer { get; set; }
        public DbSet<DetalleServiceSupplier> detalleServiceSupplier { get; set; }
        public DbSet<Location> location { get; set; }
        public DbSet<Servicio> servicio { get; set; }
        public DbSet<ServiceCategory> serviceCategory { get; set; }
        public DbSet<Supplier> supplier { get; set; }


        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
           
           modelBuilder.Entity<Supplier>().HasOne(x=>x.location);
           modelBuilder.Entity<Servicio>().HasOne(x=>x.Category);
           
           modelBuilder.Entity<DetalleServiceSupplier>().HasOne(x=>x.SupplierDetail);
           modelBuilder.Entity<DetalleServiceSupplier>().HasOne(x=>x.ServicioDetail);
        }
    }
}