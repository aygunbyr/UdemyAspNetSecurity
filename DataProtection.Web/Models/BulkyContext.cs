using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace DataProtection.Web.Models
{
    public partial class BulkyContext : DbContext
    {
        public BulkyContext()
        {
        }

        public BulkyContext(DbContextOptions<BulkyContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Products> Products { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>(entity =>
            {
                entity.HasIndex(e => e.CategoryId);

                entity.Property(e => e.Author).IsRequired();

                entity.Property(e => e.Description).IsRequired();

                entity.Property(e => e.ImageUrl)
                    .IsRequired()
                    .HasDefaultValueSql("(N'')");

                entity.Property(e => e.Isbn)
                    .IsRequired()
                    .HasColumnName("ISBN");

                entity.Property(e => e.Title)
                    .IsRequired()
                    .HasMaxLength(30);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
