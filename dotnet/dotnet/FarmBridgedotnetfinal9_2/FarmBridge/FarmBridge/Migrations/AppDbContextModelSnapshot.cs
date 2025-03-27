﻿// <auto-generated />
using System;
using FarmBridge.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FarmBridge.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("FarmBridge.Models.Buyer", b =>
                {
                    b.Property<int>("BuyerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("BuyerId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("varchar(200)");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("PhoneNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("BuyerId");

                    b.ToTable("Buyers");
                });

            modelBuilder.Entity("FarmBridge.Models.Cart", b =>
                {
                    b.Property<int>("CartID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CartID"));

                    b.Property<int>("BuyerID")
                        .HasColumnType("int");

                    b.HasKey("CartID");

                    b.HasIndex("BuyerID");

                    b.ToTable("Carts");
                });

            modelBuilder.Entity("FarmBridge.Models.CartItem", b =>
                {
                    b.Property<int>("ItemID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ItemID"));

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("CropID")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("ItemID");

                    b.HasIndex("CartID");

                    b.HasIndex("CropID");

                    b.ToTable("CartItems");
                });

            modelBuilder.Entity("FarmBridge.Models.Crops", b =>
                {
                    b.Property<int>("CropID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("CropID"));

                    b.Property<int>("FarmerID")
                        .HasColumnType("int");

                    b.Property<byte[]>("Image")
                        .HasColumnType("longblob");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<float>("Price")
                        .HasColumnType("float");

                    b.Property<float>("Quantity")
                        .HasColumnType("float");

                    b.Property<string>("Season")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .ValueGeneratedOnAdd()
                        .HasMaxLength(50)
                        .HasColumnType("varchar(50)")
                        .HasDefaultValue("PENDING");

                    b.HasKey("CropID");

                    b.HasIndex("FarmerID");

                    b.ToTable("Crops");
                });

            modelBuilder.Entity("FarmBridge.Models.Farmer", b =>
                {
                    b.Property<int>("FarmerID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("FarmerID"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("AdharCardNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("ContactNo")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("FullName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.HasKey("FarmerID");

                    b.ToTable("Farmers");
                });

            modelBuilder.Entity("FarmBridge.Models.Order", b =>
                {
                    b.Property<int>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderID"));

                    b.Property<int>("BuyerID")
                        .HasColumnType("int");

                    b.Property<int>("CartID")
                        .HasColumnType("int");

                    b.Property<int>("FarmerID")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("PaymentIntentId")
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("varchar(20)");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderID");

                    b.HasIndex("BuyerID");

                    b.HasIndex("CartID");

                    b.HasIndex("FarmerID");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("FarmBridge.Models.OrderDetails", b =>
                {
                    b.Property<int>("OrderDetailID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("OrderDetailID"));

                    b.Property<int>("BuyerID")
                        .HasColumnType("int");

                    b.Property<string>("CropName")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("varchar(255)");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime(6)");

                    b.Property<int>("FarmerID")
                        .HasColumnType("int");

                    b.Property<int>("OrderID")
                        .HasColumnType("int");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderDetailID");

                    b.HasIndex("BuyerID");

                    b.HasIndex("FarmerID");

                    b.HasIndex("OrderID");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("FarmBridge.Models.Cart", b =>
                {
                    b.HasOne("FarmBridge.Models.Buyer", "Buyer")
                        .WithMany("Carts")
                        .HasForeignKey("BuyerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");
                });

            modelBuilder.Entity("FarmBridge.Models.CartItem", b =>
                {
                    b.HasOne("FarmBridge.Models.Cart", "Cart")
                        .WithMany("CartItems")
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmBridge.Models.Crops", "Crop")
                        .WithMany("CartItems")
                        .HasForeignKey("CropID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Cart");

                    b.Navigation("Crop");
                });

            modelBuilder.Entity("FarmBridge.Models.Crops", b =>
                {
                    b.HasOne("FarmBridge.Models.Farmer", "Farmer")
                        .WithMany("Crops")
                        .HasForeignKey("FarmerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Farmer");
                });

            modelBuilder.Entity("FarmBridge.Models.Order", b =>
                {
                    b.HasOne("FarmBridge.Models.Buyer", "Buyer")
                        .WithMany("Orders")
                        .HasForeignKey("BuyerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmBridge.Models.Cart", "Cart")
                        .WithMany()
                        .HasForeignKey("CartID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmBridge.Models.Farmer", "Farmer")
                        .WithMany("Orders")
                        .HasForeignKey("FarmerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Cart");

                    b.Navigation("Farmer");
                });

            modelBuilder.Entity("FarmBridge.Models.OrderDetails", b =>
                {
                    b.HasOne("FarmBridge.Models.Buyer", "Buyer")
                        .WithMany()
                        .HasForeignKey("BuyerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmBridge.Models.Farmer", "Farmer")
                        .WithMany()
                        .HasForeignKey("FarmerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("FarmBridge.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Buyer");

                    b.Navigation("Farmer");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("FarmBridge.Models.Buyer", b =>
                {
                    b.Navigation("Carts");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FarmBridge.Models.Cart", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("FarmBridge.Models.Crops", b =>
                {
                    b.Navigation("CartItems");
                });

            modelBuilder.Entity("FarmBridge.Models.Farmer", b =>
                {
                    b.Navigation("Crops");

                    b.Navigation("Orders");
                });

            modelBuilder.Entity("FarmBridge.Models.Order", b =>
                {
                    b.Navigation("OrderDetails");
                });
#pragma warning restore 612, 618
        }
    }
}
