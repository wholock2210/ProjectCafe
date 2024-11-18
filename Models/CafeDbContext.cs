using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace ProjectCafe.Models;

public partial class CafeDbContext : DbContext
{
    public CafeDbContext()
    {
    }

    public CafeDbContext(DbContextOptions<CafeDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<Ban> Bans { get; set; }

    public virtual DbSet<Datban> Datbans { get; set; }

    public virtual DbSet<Dsmonordertb> Dsmonordertbs { get; set; }

    public virtual DbSet<Dsmonordertq> Dsmonordertqs { get; set; }

    public virtual DbSet<Khachhang> Khachhangs { get; set; }

    public virtual DbSet<Loaimon> Loaimons { get; set; }

    public virtual DbSet<Mon> Mons { get; set; }

    public virtual DbSet<Ordertaiban> Ordertaibans { get; set; }

    public virtual DbSet<Ordertaiquay> Ordertaiquays { get; set; }

    public virtual DbSet<Tang> Tangs { get; set; }

    public virtual DbSet<Trangthaiban> Trangthaibans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlite("Data Source=Resources/Database/SQLiteCafe.db");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Ban>(entity =>
        {
            entity.HasKey(e => new { e.Maban, e.Tang });

            entity.ToTable("BAN");

            entity.Property(e => e.Maban).HasColumnName("MABAN");
            entity.Property(e => e.Tang).HasColumnName("TANG");
            entity.Property(e => e.Matrangthaiban).HasColumnName("MATRANGTHAIBAN");
            entity.Property(e => e.Sizeban).HasColumnName("SIZEBAN");

            entity.HasOne(d => d.MatrangthaibanNavigation).WithMany(p => p.Bans).HasForeignKey(d => d.Matrangthaiban);

            entity.HasOne(d => d.TangNavigation).WithMany(p => p.Bans).HasForeignKey(d => d.Tang);
        });

        modelBuilder.Entity<Datban>(entity =>
        {
            entity.HasKey(e => new { e.Madatban, e.Maban, e.Tang });

            entity.ToTable("DATBAN");

            entity.Property(e => e.Madatban).HasColumnName("MADATBAN");
            entity.Property(e => e.Maban).HasColumnName("MABAN");
            entity.Property(e => e.Tang).HasColumnName("TANG");
            entity.Property(e => e.Thoigianra).HasColumnName("THOIGIANRA");
            entity.Property(e => e.Thoigianvao).HasColumnName("THOIGIANVAO");

            entity.HasOne(d => d.Ban).WithMany(p => p.Datbans)
                .HasForeignKey(d => new { d.Maban, d.Tang })
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Dsmonordertb>(entity =>
        {
            entity.HasKey(e => new { e.Maordertb, e.Makh, e.Maban, e.Tang, e.Mamon });

            entity.ToTable("DSMONORDERTB");

            entity.Property(e => e.Maordertb).HasColumnName("MAORDERTB");
            entity.Property(e => e.Makh).HasColumnName("MAKH");
            entity.Property(e => e.Maban).HasColumnName("MABAN");
            entity.Property(e => e.Tang).HasColumnName("TANG");
            entity.Property(e => e.Mamon).HasColumnName("MAMON");
            entity.Property(e => e.Size).HasColumnName("SIZE");
            entity.Property(e => e.Soluong)
                .HasDefaultValue(1)
                .HasColumnName("SOLUONG");

            entity.HasOne(d => d.MamonNavigation).WithMany(p => p.Dsmonordertbs)
                .HasForeignKey(d => d.Mamon)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Ordertaiban).WithMany(p => p.Dsmonordertbs)
                .HasForeignKey(d => new { d.Maordertb, d.Makh, d.Maban, d.Tang })
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Dsmonordertq>(entity =>
        {
            entity.HasKey(e => new { e.Mamon, e.Maordertq, e.Makh });

            entity.ToTable("DSMONORDERTQ");

            entity.Property(e => e.Mamon).HasColumnName("MAMON");
            entity.Property(e => e.Maordertq).HasColumnName("MAORDERTQ");
            entity.Property(e => e.Makh).HasColumnName("MAKH");
            entity.Property(e => e.Size).HasColumnName("SIZE");
            entity.Property(e => e.Soluong)
                .HasDefaultValue(1)
                .HasColumnName("SOLUONG");

            entity.HasOne(d => d.MamonNavigation).WithMany(p => p.Dsmonordertqs)
                .HasForeignKey(d => d.Mamon)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Ordertaiquay).WithMany(p => p.Dsmonordertqs)
                .HasForeignKey(d => new { d.Maordertq, d.Makh })
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Khachhang>(entity =>
        {
            entity.HasKey(e => e.Makh);

            entity.ToTable("KHACHHANG");

            entity.Property(e => e.Makh)
                .ValueGeneratedNever()
                .HasColumnName("MAKH");
            entity.Property(e => e.Email).HasColumnName("EMAIL");
            entity.Property(e => e.Sdt).HasColumnName("SDT");
            entity.Property(e => e.Tenkh).HasColumnName("TENKH");
        });

        modelBuilder.Entity<Loaimon>(entity =>
        {
            entity.HasKey(e => e.Maloaimon);

            entity.ToTable("LOAIMON");

            entity.Property(e => e.Maloaimon)
                .ValueGeneratedNever()
                .HasColumnName("MALOAIMON");
            entity.Property(e => e.Tenloaimon).HasColumnName("TENLOAIMON");
        });

        modelBuilder.Entity<Mon>(entity =>
        {
            entity.HasKey(e => e.Mamon);

            entity.ToTable("MON");

            entity.Property(e => e.Mamon)
                .ValueGeneratedNever()
                .HasColumnName("MAMON");
            entity.Property(e => e.Gia).HasColumnName("GIA");
            entity.Property(e => e.Maloaimon).HasColumnName("MALOAIMON");
            entity.Property(e => e.Tenmon).HasColumnName("TENMON");

            entity.HasOne(d => d.MaloaimonNavigation).WithMany(p => p.Mons).HasForeignKey(d => d.Maloaimon);
        });

        modelBuilder.Entity<Ordertaiban>(entity =>
        {
            entity.HasKey(e => new { e.Maordertb, e.Makh, e.Maban, e.Tang });

            entity.ToTable("ORDERTAIBAN");

            entity.Property(e => e.Maordertb).HasColumnName("MAORDERTB");
            entity.Property(e => e.Makh).HasColumnName("MAKH");
            entity.Property(e => e.Maban).HasColumnName("MABAN");
            entity.Property(e => e.Tang).HasColumnName("TANG");
            entity.Property(e => e.Ghichu).HasColumnName("GHICHU");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Ordertaibans)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Ban).WithMany(p => p.Ordertaibans)
                .HasForeignKey(d => new { d.Maban, d.Tang })
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<Ordertaiquay>(entity =>
        {
            entity.HasKey(e => new { e.Maordertq, e.Makh });

            entity.ToTable("ORDERTAIQUAY");

            entity.Property(e => e.Maordertq).HasColumnName("MAORDERTQ");
            entity.Property(e => e.Makh).HasColumnName("MAKH");
            entity.Property(e => e.Ghichu).HasColumnName("GHICHU");
            entity.Property(e => e.Maban).HasColumnName("MABAN");
            entity.Property(e => e.Tang).HasColumnName("TANG");

            entity.HasOne(d => d.MakhNavigation).WithMany(p => p.Ordertaiquays)
                .HasForeignKey(d => d.Makh)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Ban).WithMany(p => p.Ordertaiquays).HasForeignKey(d => new { d.Maban, d.Tang });
        });

        modelBuilder.Entity<Tang>(entity =>
        {
            entity.HasKey(e => e.Tang1);

            entity.ToTable("TANG");

            entity.Property(e => e.Tang1)
                .ValueGeneratedNever()
                .HasColumnName("TANG");
        });

        modelBuilder.Entity<Trangthaiban>(entity =>
        {
            entity.HasKey(e => e.Matrangthaiban);

            entity.ToTable("TRANGTHAIBAN");

            entity.Property(e => e.Matrangthaiban)
                .ValueGeneratedNever()
                .HasColumnName("MATRANGTHAIBAN");
            entity.Property(e => e.Tentrangthaiban).HasColumnName("TENTRANGTHAIBAN");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
