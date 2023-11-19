﻿// <auto-generated />
using System;
using MarketingSurplus.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace MarketingSurplus.Migrations
{
    [DbContext(typeof(MarketingSurplusDbContext))]
    partial class MarketingSurplusDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.14")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("MarketingSurplus.Models.Charity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Charities");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Company", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CompanyTypeId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LicenseNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CompanyTypeId");

                    b.ToTable("Companies");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompanyProduct", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("ProductId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("ProductId");

                    b.ToTable("CompanyProducts");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompanyType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("TypeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("CompanyTypes");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompayProductOrder", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<int>("CompanyProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("TotalPrice")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyProductId");

                    b.HasIndex("OrderId");

                    b.ToTable("CompayProductOrders");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompayProductOrderOffer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompayProductOrderId")
                        .HasColumnType("int");

                    b.Property<string>("Note")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("OfferId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompayProductOrderId");

                    b.HasIndex("OfferId");

                    b.ToTable("CompayProductOrderOffers");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Donation", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CharityId")
                        .HasColumnType("int");

                    b.Property<int>("CompanyProductId")
                        .HasColumnType("int");

                    b.Property<int>("OrderTypeId")
                        .HasColumnType("int");

                    b.Property<float>("PricePay")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.HasIndex("CharityId");

                    b.HasIndex("CompanyProductId");

                    b.HasIndex("OrderTypeId");

                    b.ToTable("Donations");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Offer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Offers");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Order", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Amount")
                        .HasColumnType("int");

                    b.Property<string>("Descripation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsDelivery")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PayMethodId")
                        .HasColumnType("int");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PayMethodId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("MarketingSurplus.Models.OrderType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderTypes");
                });

            modelBuilder.Entity("MarketingSurplus.Models.PayMethod", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("PayMethods");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Product", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descripation")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Expiration")
                        .HasColumnType("datetime2");

                    b.Property<bool>("IsExpiration")
                        .HasColumnType("bit");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("Price")
                        .HasColumnType("real");

                    b.HasKey("Id");

                    b.ToTable("Products");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Rate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("RateNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Rates");
                });

            modelBuilder.Entity("MarketingSurplus.Models.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PayPal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("QRCode")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MarketingSurplus.Models.UserCompany", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("CompanyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CompanyId");

                    b.HasIndex("UserId");

                    b.ToTable("UserCompanies");
                });

            modelBuilder.Entity("MarketingSurplus.Models.UserCompanyRate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RateId")
                        .HasColumnType("int");

                    b.Property<int>("UserCompanyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RateId");

                    b.HasIndex("UserCompanyId");

                    b.ToTable("UserCompanyRates");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Company", b =>
                {
                    b.HasOne("MarketingSurplus.Models.CompanyType", "CompanyType")
                        .WithMany("Companies")
                        .HasForeignKey("CompanyTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyType");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompanyProduct", b =>
                {
                    b.HasOne("MarketingSurplus.Models.Company", "Company")
                        .WithMany("CompanyProducts")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.Product", "Product")
                        .WithMany("CompanyProducts")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompayProductOrder", b =>
                {
                    b.HasOne("MarketingSurplus.Models.CompanyProduct", "CompanyProduct")
                        .WithMany("CompayProductOrders")
                        .HasForeignKey("CompanyProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.Order", "Order")
                        .WithMany("CompayProductOrders")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompanyProduct");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompayProductOrderOffer", b =>
                {
                    b.HasOne("MarketingSurplus.Models.CompayProductOrder", "CompayProductOrder")
                        .WithMany("CompayProductOrderOffers")
                        .HasForeignKey("CompayProductOrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.Offer", "Offer")
                        .WithMany("CompayProductOrderOffers")
                        .HasForeignKey("OfferId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CompayProductOrder");

                    b.Navigation("Offer");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Donation", b =>
                {
                    b.HasOne("MarketingSurplus.Models.Charity", "Charity")
                        .WithMany("Donations")
                        .HasForeignKey("CharityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.CompanyProduct", "CompanyProduct")
                        .WithMany("Donations")
                        .HasForeignKey("CompanyProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.OrderType", "OrderType")
                        .WithMany("Donations")
                        .HasForeignKey("OrderTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Charity");

                    b.Navigation("CompanyProduct");

                    b.Navigation("OrderType");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Order", b =>
                {
                    b.HasOne("MarketingSurplus.Models.PayMethod", "PayMethod")
                        .WithMany("Orders")
                        .HasForeignKey("PayMethodId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.User", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PayMethod");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketingSurplus.Models.UserCompany", b =>
                {
                    b.HasOne("MarketingSurplus.Models.Company", "Company")
                        .WithMany("UserCompanies")
                        .HasForeignKey("CompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.User", "User")
                        .WithMany("UserCompanies")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Company");

                    b.Navigation("User");
                });

            modelBuilder.Entity("MarketingSurplus.Models.UserCompanyRate", b =>
                {
                    b.HasOne("MarketingSurplus.Models.Rate", "Rate")
                        .WithMany("CompanyRates")
                        .HasForeignKey("RateId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MarketingSurplus.Models.UserCompany", "UserCompany")
                        .WithMany("UserCompanyRates")
                        .HasForeignKey("UserCompanyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Rate");

                    b.Navigation("UserCompany");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Charity", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Company", b =>
                {
                    b.Navigation("CompanyProducts");

                    b.Navigation("UserCompanies");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompanyProduct", b =>
                {
                    b.Navigation("CompayProductOrders");

                    b.Navigation("Donations");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompanyType", b =>
                {
                    b.Navigation("Companies");
                });

            modelBuilder.Entity("MarketingSurplus.Models.CompayProductOrder", b =>
                {
                    b.Navigation("CompayProductOrderOffers");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Offer", b =>
                {
                    b.Navigation("CompayProductOrderOffers");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Order", b =>
                {
                    b.Navigation("CompayProductOrders");
                });

            modelBuilder.Entity("MarketingSurplus.Models.OrderType", b =>
                {
                    b.Navigation("Donations");
                });

            modelBuilder.Entity("MarketingSurplus.Models.PayMethod", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Product", b =>
                {
                    b.Navigation("CompanyProducts");
                });

            modelBuilder.Entity("MarketingSurplus.Models.Rate", b =>
                {
                    b.Navigation("CompanyRates");
                });

            modelBuilder.Entity("MarketingSurplus.Models.User", b =>
                {
                    b.Navigation("Orders");

                    b.Navigation("UserCompanies");
                });

            modelBuilder.Entity("MarketingSurplus.Models.UserCompany", b =>
                {
                    b.Navigation("UserCompanyRates");
                });
#pragma warning restore 612, 618
        }
    }
}
