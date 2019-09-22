
using Microsoft.EntityFrameworkCore;
using RapiSolverWeb.Models;

namespace Hospital.Repositoy.dbcontext {
    public class ApplicationDbContext : DbContext {
        public DbSet<Person> Persons { get; set; }


        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options) : base (options) {

        }

        protected override void OnModelCreating (ModelBuilder modelBuilder) {
           

        }
    }
}