using Horus.Models;
using Microsoft.EntityFrameworkCore;

namespace Horus.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; } 
        public DbSet<Address> Addresses { get; set; } 
        public DbSet<Event> Events { get; set; } 
        public DbSet<SystemEvent> SystemEvents { get; set; } 
        public DbSet<Module> Modules { get; set; } 
        public DbSet<SystemModule> SystemModules { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

           
            builder.Entity<Client>(entity =>
            {
                entity.HasIndex(u => u.Email)
                .IsUnique();
                entity.HasIndex(u => u.Cnpj)
                .IsUnique();
                entity.HasIndex(u => u.Cellphone)
                .IsUnique();

            });
        }
    }
}