// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace PomeloSoftBlogCaseMVC.Models
{
    public partial class PomelosoftBlogCaseContext : DbContext
    {
        public PomelosoftBlogCaseContext()
        {
        }

        public PomelosoftBlogCaseContext(DbContextOptions<PomelosoftBlogCaseContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblKullanici> TblKullanici { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Data Source=DESKTOP-TVS9I3D\\SQLEXPRESS;Initial Catalog=PomeloSoftBlogCase;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "Turkish_CI_AS");

            modelBuilder.Entity<TblKullanici>(entity =>
            {
                entity.ToTable("tbl_Kullanici");

                entity.Property(e => e.KullaniciAdi)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KullaniciNickName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.KullaniciParola)
                    .IsRequired()
                    .HasMaxLength(100);

                entity.Property(e => e.KullaniciSoyadi)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}