using EA.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EA.DAL
{
    internal class BPContext : DbContext 
    {
        public BPContext()
        {
            
        }
        public BPContext(DbContextOptions<BPContext> options) : base(options)
        {

        }
        public DbSet<IndexComponent> IndexComponents { get; set; }
        public DbSet<AboutPageComponent> AboutPageComponents { get; set; }
        public DbSet<ProductsComponent> ProductsComponents { get; set; }
        public DbSet<CategoryComponent> CategoryComponents { get; set; }

        public DbSet<ServicesComponent> ServicesComponents { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<IndexComponent>(entity =>
            {
                entity.HasKey(e => e.Id);
                entity.Property(e => e.Id)
                .HasColumnName("Id");
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=BP;User Id=sa;Password=E93.melanion;Encrypt=False;");

            base.OnConfiguring(optionsBuilder);
        }
    }
}
