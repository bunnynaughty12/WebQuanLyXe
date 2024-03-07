﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLyBaiGiuXe.Data;

#nullable disable

namespace QuanLyBaiGiuXe.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20240306010934_AddColumn")]
    partial class AddColumn
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("QuanLyBaiGiuXe.Models.BaiGiuXe", b =>
                {
                    b.Property<int>("MaBaiGiuXe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaBaiGiuXe"));

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("SucChua")
                        .HasColumnType("int");

                    b.Property<string>("TenBaiGiuXe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaBaiGiuXe");

                    b.ToTable("BaiGiuXe");
                });

            modelBuilder.Entity("QuanLyBaiGiuXe.Models.TheGiuXe", b =>
                {
                    b.Property<int>("MaTheGiuXe")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaTheGiuXe"));

                    b.Property<string>("BienSoXe")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("MaBaiGiuXe")
                        .HasColumnType("int");

                    b.Property<DateTime>("ThoiGianVao")
                        .HasColumnType("datetime2");

                    b.Property<bool>("TrangThaiXe")
                        .HasColumnType("bit");

                    b.HasKey("MaTheGiuXe");

                    b.HasIndex("MaBaiGiuXe");

                    b.ToTable("TheGiuXe");
                });

            modelBuilder.Entity("QuanLyBaiGiuXe.Models.TheGiuXe", b =>
                {
                    b.HasOne("QuanLyBaiGiuXe.Models.BaiGiuXe", "BaiGiuXe")
                        .WithMany("TheGiuXes")
                        .HasForeignKey("MaBaiGiuXe")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("BaiGiuXe");
                });

            modelBuilder.Entity("QuanLyBaiGiuXe.Models.BaiGiuXe", b =>
                {
                    b.Navigation("TheGiuXes");
                });
#pragma warning restore 612, 618
        }
    }
}
