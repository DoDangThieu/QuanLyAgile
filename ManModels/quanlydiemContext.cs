using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace QuanLyAgile.ManModels
{
    public partial class quanlydiemContext : DbContext
    {
        public quanlydiemContext()
        {
        }

        public quanlydiemContext(DbContextOptions<quanlydiemContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Canbo> Canbos { get; set; } = null!;
        public virtual DbSet<Diem> Diems { get; set; } = null!;
        public virtual DbSet<Giaovien> Giaoviens { get; set; } = null!;
        public virtual DbSet<Khoa> Khoas { get; set; } = null!;
        public virtual DbSet<Lop> Lops { get; set; } = null!;
        public virtual DbSet<Monhoc> Monhocs { get; set; } = null!;
        public virtual DbSet<Sinhvien> Sinhviens { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS;Database=quanlydiem;Trusted_Connection=True; TrustServerCertificate =True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Canbo>(entity =>
            {
                entity.HasKey(e => e.Macb)
                    .HasName("PK__canbo__272482022A5079D8");

                entity.ToTable("canbo");

                entity.Property(e => e.Macb)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(5)
                    .HasColumnName("gioitinh");

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Quequan)
                    .HasMaxLength(50)
                    .HasColumnName("quequan");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("sdt");

                entity.Property(e => e.Tendn)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Diem>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("diem");

                entity.Property(e => e.Diem1).HasColumnName("diem");

                entity.Property(e => e.Lanthi).HasColumnName("lanthi");

                entity.Property(e => e.Magv)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Mamon)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Masv)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaynhapdiem)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaynhapdiem")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.Ngaythi).HasColumnType("datetime");

                entity.HasOne(d => d.MagvNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Magv)
                    .HasConstraintName("giaovien_diem");

                entity.HasOne(d => d.MamonNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Mamon)
                    .HasConstraintName("monhoc_diem");

                entity.HasOne(d => d.MasvNavigation)
                    .WithMany()
                    .HasForeignKey(d => d.Masv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("sinhvien_diem");
            });

            modelBuilder.Entity<Giaovien>(entity =>
            {
                entity.HasKey(e => e.Magv)
                    .HasName("PK__giaovien__2724A2BBB5D8B2A5");

                entity.ToTable("giaovien");

                entity.Property(e => e.Magv)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(5)
                    .HasColumnName("gioitinh");

                entity.Property(e => e.Hoten).HasMaxLength(50);

                entity.Property(e => e.Level)
                    .HasColumnName("level")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Quequan)
                    .HasMaxLength(50)
                    .HasColumnName("quequan");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("sdt");

                entity.Property(e => e.Tennd)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Khoa>(entity =>
            {
                entity.HasKey(e => e.Makhoa)
                    .HasName("PK__khoa__5E7F1383B4ADB1B7");

                entity.ToTable("khoa");

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tenkhoa)
                    .HasMaxLength(50)
                    .HasColumnName("tenkhoa");
            });

            modelBuilder.Entity<Lop>(entity =>
            {
                entity.HasKey(e => e.Malop)
                    .HasName("PK__lop__3313BBCD5603891A");

                entity.ToTable("lop");

                entity.Property(e => e.Malop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Siso).HasColumnName("siso");

                entity.Property(e => e.Tenlop).HasMaxLength(50);
            });

            modelBuilder.Entity<Monhoc>(entity =>
            {
                entity.HasKey(e => e.Mamon)
                    .HasName("PK__monhoc__33DA29C2FE385E51");

                entity.ToTable("monhoc");

                entity.Property(e => e.Mamon)
                    .HasMaxLength(5)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Tenmon).HasMaxLength(30);
            });

            modelBuilder.Entity<Sinhvien>(entity =>
            {
                entity.HasKey(e => e.Masv)
                    .HasName("PK__sinhvien__27240C22E4F3EF13");

                entity.ToTable("sinhvien");

                entity.Property(e => e.Masv)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Diachi)
                    .HasMaxLength(50)
                    .HasColumnName("diachi");

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("email");

                entity.Property(e => e.Gioitinh)
                    .HasMaxLength(5)
                    .HasColumnName("gioitinh");

                entity.Property(e => e.Macb)
                    .HasMaxLength(7)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Makhoa)
                    .HasMaxLength(4)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Malop)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Matkhau)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Muc)
                    .HasMaxLength(2)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Ngaysinh)
                    .HasColumnType("datetime")
                    .HasColumnName("ngaysinh");

                entity.Property(e => e.Quequan)
                    .HasMaxLength(50)
                    .HasColumnName("quequan");

                entity.Property(e => e.Sdt)
                    .HasMaxLength(12)
                    .IsUnicode(false)
                    .HasColumnName("sdt");

                entity.Property(e => e.Tennd)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Tensv).HasMaxLength(50);

                entity.HasOne(d => d.MacbNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.Macb)
                    .HasConstraintName("FK__sinhvien__Macb__5535A963");

                entity.HasOne(d => d.MakhoaNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.Makhoa)
                    .HasConstraintName("FK__sinhvien__Makhoa__5629CD9C");

                entity.HasOne(d => d.MalopNavigation)
                    .WithMany(p => p.Sinhviens)
                    .HasForeignKey(d => d.Malop)
                    .HasConstraintName("FK__sinhvien__Malop__5441852A");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
