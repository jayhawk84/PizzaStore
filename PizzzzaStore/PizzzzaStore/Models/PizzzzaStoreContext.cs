using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace PizzzzaStore.Models
{
    public partial class PizzzzaStoreContext : DbContext
    {
        public PizzzzaStoreContext()
        {
        }

        public PizzzzaStoreContext(DbContextOptions<PizzzzaStoreContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Pizza> Pizza { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:pizzastoreserver.database.windows.net,1433;Initial Catalog=PizzzzaStore;Persist Security Info=False;User ID=pizza;Password=!Q@W3e4r;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Pizza>(entity =>
            {
                entity.Property(e => e.Dough)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Price)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Sauce)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Toppings)
                    .HasMaxLength(120)
                    .IsUnicode(false);

                entity.Property(e => e.Zzzzaname)
                    .HasColumnName("ZZZZAName")
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
