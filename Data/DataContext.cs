using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Horus.Models;
using Microsoft.EntityFrameworkCore;

namespace Horus.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }
        public DbSet<Client> Clients { get; set; } = null!;
        public DbSet<Address> Addresses { get; set; } = null!;
        public DbSet<Event> Events { get; set; } = null!;
        public DbSet<SystemEvent> SystemEvents { get; set; } = null!;
        public DbSet<Module> Modules { get; set; } = null!;
        public DbSet<SystemModule> SystemModules { get; set; } = null!;

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<Client>(entity =>

                entity.HasOne(x => x.Address)
                .WithOne(x => x.Client)
                .HasForeignKey<Address>(x => x.ClientId));

            builder.Entity<Client>(entity =>
            {
                entity.HasIndex(u => u.Email)
                .IsUnique();
                entity.HasIndex(u => u.Cnpj)
                .IsUnique();
                entity.HasIndex(u => u.Cellphone)
                .IsUnique();

                entity.HasMany(c => c.SystemEvents)
               .WithOne(se => se.Client)
               .HasForeignKey(x => x.ClientId);

                entity.HasMany(c => c.SystemModules)
                .WithOne(sm => sm.Client)
                .HasForeignKey(x => x.ClientId);
            });
        }
    }
}