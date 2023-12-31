﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using webapi.Data;

#nullable disable

namespace webapi.Migrations
{
    [DbContext(typeof(MainDbContext))]
    [Migration("20230823110325_teklif")]
    partial class teklif
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "7.0.10");

            modelBuilder.Entity("webapi.Entity.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Creator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonNumarasi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Updater")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("webapi.Entity.Kategori", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Kategori");
                });

            modelBuilder.Entity("webapi.Entity.Log.ExceptionLog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("Date")
                        .HasColumnType("TEXT");

                    b.Property<string>("Exception")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("HttpStatusCode")
                        .HasColumnType("INTEGER");

                    b.Property<string>("RequestUrl")
                        .IsRequired()
                        .HasMaxLength(1000)
                        .HasColumnType("TEXT");

                    b.Property<string>("StackTrace")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("ExceptionLog");
                });

            modelBuilder.Entity("webapi.Entity.Musteri", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("CreationDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Creator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Firma")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Soyadi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("TelefonNumarasi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<DateTime?>("UpdateDate")
                        .HasColumnType("TEXT");

                    b.Property<int?>("Updater")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.ToTable("Musteri");
                });

            modelBuilder.Entity("webapi.Entity.Teklif", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("IskontoOrani")
                        .HasColumnType("TEXT");

                    b.Property<int>("MusteriId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeklifNo")
                        .HasColumnType("INTEGER");

                    b.Property<int>("TeklifSuresi")
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("TeklifTarihi")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ToplamFiyatEUR")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ToplamFiyatTRY")
                        .HasColumnType("TEXT");

                    b.Property<decimal>("ToplamFiyatUSD")
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Teklif");
                });

            modelBuilder.Entity("webapi.Entity.TeklifItem", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("Adet")
                        .HasColumnType("INTEGER");

                    b.Property<decimal>("BirimFiyat")
                        .HasColumnType("TEXT");

                    b.Property<int>("TeklifId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UrunId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("TeklifId");

                    b.ToTable("TeklifItem");
                });

            modelBuilder.Entity("webapi.Entity.Urun", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Aciklama")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Adi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<int>("Creator")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Ebat")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<decimal>("Fiyat")
                        .HasColumnType("TEXT");

                    b.Property<bool>("IsDeleted")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kategori")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Kdv")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ParaBirimi")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Tedarikci")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Urun");
                });

            modelBuilder.Entity("webapi.Entity.TeklifItem", b =>
                {
                    b.HasOne("webapi.Entity.Teklif", null)
                        .WithMany("TeklifItems")
                        .HasForeignKey("TeklifId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("webapi.Entity.Teklif", b =>
                {
                    b.Navigation("TeklifItems");
                });
#pragma warning restore 612, 618
        }
    }
}
