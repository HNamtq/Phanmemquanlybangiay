﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using _1_DAL.Dbcontext;

#nullable disable

namespace _1_DAL.Migrations
{
    [DbContext(typeof(QuanLyBanHangGiayContext))]
    [Migration("20230801180200_h1")]
    partial class h1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("_1_DAL.DomainMolder.ChucVu", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("ChucVu", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.HinhThucThanhToan", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("HinhThucThanhToan", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.HoaDon", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDHTTT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDKH")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayTao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayThanhToan")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("ThanhTien")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHTTT");

                    b.HasIndex("IDKH");

                    b.HasIndex("IDNV");

                    b.ToTable("HoaDon", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.HoaDonChiTiet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("DonGia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IDHD")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSPCT")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuong")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDHD");

                    b.HasIndex("IDSPCT");

                    b.ToTable("HoaDonChiTiet", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.KhachHang", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("HovaTen")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.Property<int?>("Poin")
                        .HasColumnType("int");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.Property<int?>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KhachHang", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.KhuyenMai", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HinhThuc")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayBatDau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("NgayKetThuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("KhuyenMai", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.KichThuoc", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("Size", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.LoaiSanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("LoaiSanPham", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.MauSac", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("MauSac", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.NhaCungCap", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("NCC", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.NhanVien", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("AnhNv")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CCCD")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("GioiTinh")
                        .HasColumnType("int");

                    b.Property<string>("HoTen")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<Guid>("IDCV")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("MatKhau")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasMaxLength(10)
                        .HasColumnType("nvarchar(10)");

                    b.HasKey("ID");

                    b.HasIndex("IDCV");

                    b.ToTable("NhanVien", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.NSX", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("NSX", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.SanPham", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("GhiChu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.ToTable("SanPham", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.SanPhamChiTiet", b =>
                {
                    b.Property<Guid>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("GiaBan")
                        .HasMaxLength(64)
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("GiaNhap")
                        .HasMaxLength(64)
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("HinhAnh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<Guid>("IDKM")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDLOAI")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDMS")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNCC")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDNSX")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSP")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IDSZ")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Ma")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MoTa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SoLuongTon")
                        .HasColumnType("int");

                    b.Property<int>("TrangThai")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("IDKM");

                    b.HasIndex("IDLOAI");

                    b.HasIndex("IDMS");

                    b.HasIndex("IDNCC");

                    b.HasIndex("IDNSX");

                    b.HasIndex("IDSP");

                    b.HasIndex("IDSZ");

                    b.ToTable("SanPhamChiTiet", (string)null);
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.HoaDon", b =>
                {
                    b.HasOne("_1_DAL.DomainMolder.HinhThucThanhToan", "hinhthucthanhtoan")
                        .WithMany("hoadon")
                        .HasForeignKey("IDHTTT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.KhachHang", "khachhang")
                        .WithMany("hoadon")
                        .HasForeignKey("IDKH")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.NhanVien", "nhanvien")
                        .WithMany("hoadon")
                        .HasForeignKey("IDNV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hinhthucthanhtoan");

                    b.Navigation("khachhang");

                    b.Navigation("nhanvien");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.HoaDonChiTiet", b =>
                {
                    b.HasOne("_1_DAL.DomainMolder.HoaDon", "hoadon")
                        .WithMany("hoadonchitiet")
                        .HasForeignKey("IDHD")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.SanPhamChiTiet", "sanphamchitiet")
                        .WithMany("hoadonchitiet")
                        .HasForeignKey("IDSPCT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("hoadon");

                    b.Navigation("sanphamchitiet");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.NhanVien", b =>
                {
                    b.HasOne("_1_DAL.DomainMolder.ChucVu", "ChucVu")
                        .WithMany("nhanvien")
                        .HasForeignKey("IDCV")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ChucVu");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.SanPhamChiTiet", b =>
                {
                    b.HasOne("_1_DAL.DomainMolder.KhuyenMai", "khuyenmai")
                        .WithMany("spct")
                        .HasForeignKey("IDKM")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.LoaiSanPham", "loaiSanPham")
                        .WithMany("spct")
                        .HasForeignKey("IDLOAI")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.MauSac", "mausac")
                        .WithMany("spct")
                        .HasForeignKey("IDMS")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.NhaCungCap", "nhacungcap")
                        .WithMany("spct")
                        .HasForeignKey("IDNCC")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.NSX", "nsx")
                        .WithMany("spct")
                        .HasForeignKey("IDNSX")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.SanPham", "sanpham")
                        .WithMany("spct")
                        .HasForeignKey("IDSP")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("_1_DAL.DomainMolder.KichThuoc", "size")
                        .WithMany("spct")
                        .HasForeignKey("IDSZ")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("khuyenmai");

                    b.Navigation("loaiSanPham");

                    b.Navigation("mausac");

                    b.Navigation("nhacungcap");

                    b.Navigation("nsx");

                    b.Navigation("sanpham");

                    b.Navigation("size");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.ChucVu", b =>
                {
                    b.Navigation("nhanvien");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.HinhThucThanhToan", b =>
                {
                    b.Navigation("hoadon");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.HoaDon", b =>
                {
                    b.Navigation("hoadonchitiet");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.KhachHang", b =>
                {
                    b.Navigation("hoadon");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.KhuyenMai", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.KichThuoc", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.LoaiSanPham", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.MauSac", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.NhaCungCap", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.NhanVien", b =>
                {
                    b.Navigation("hoadon");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.NSX", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.SanPham", b =>
                {
                    b.Navigation("spct");
                });

            modelBuilder.Entity("_1_DAL.DomainMolder.SanPhamChiTiet", b =>
                {
                    b.Navigation("hoadonchitiet");
                });
#pragma warning restore 612, 618
        }
    }
}
