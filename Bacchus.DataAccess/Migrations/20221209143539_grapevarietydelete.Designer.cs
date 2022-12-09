﻿// <auto-generated />
using System;
using Bacchus.DataAccess.DbContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace Bacchus.DataAccess.Migrations
{
    [DbContext(typeof(BacchusDbContext))]
    [Migration("20221209143539_grapevarietydelete")]
    partial class grapevarietydelete
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Bacchus.Common.Entities.AddressEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("AdditionalDetails")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("DeliveryAddressId")
                        .HasColumnType("int");

                    b.Property<int?>("StatusId")
                        .HasColumnType("int");

                    b.Property<int?>("TypeId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DeliveryAddressId");

                    b.HasIndex("StatusId");

                    b.HasIndex("TypeId");

                    b.HasIndex("UserId");

                    b.ToTable("Orders", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderStatuses", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderTypeEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderTypes", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderWineEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OrderEntityId")
                        .HasColumnType("int");

                    b.Property<int>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int?>("WineEntityId")
                        .HasColumnType("int");

                    b.Property<int>("WineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("OrderId");

                    b.HasIndex("WineEntityId");

                    b.HasIndex("WineId");

                    b.ToTable("OrderWines");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.SupplierEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("MobilePhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.SupplierWineEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SupplierEntityId")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int?>("WineEntityId")
                        .HasColumnType("int");

                    b.Property<int>("WineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SupplierEntityId");

                    b.HasIndex("SupplierId");

                    b.HasIndex("WineEntityId");

                    b.HasIndex("WineId");

                    b.ToTable("SupplierWineEntity");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncryptedPassword")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("MobilePhoneNumber")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Users", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.UserRoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("RoleId")
                        .HasColumnType("int");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserEntityId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRoles");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.WineEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("FamilyId")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int?>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.HasIndex("SupplierId");

                    b.ToTable("Wines", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.WineFamilyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("WineFamilies", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.AddressEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.UserEntity", null)
                        .WithMany("Addresses")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.AddressEntity", "DeliveryAddress")
                        .WithMany()
                        .HasForeignKey("DeliveryAddressId");

                    b.HasOne("Bacchus.Common.Entities.OrderStatusEntity", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId");

                    b.HasOne("Bacchus.Common.Entities.OrderTypeEntity", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId");

                    b.HasOne("Bacchus.Common.Entities.UserEntity", "User")
                        .WithMany("Orders")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DeliveryAddress");

                    b.Navigation("Status");

                    b.Navigation("Type");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderWineEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.OrderEntity", null)
                        .WithMany("OrdersWines")
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("Bacchus.Common.Entities.OrderEntity", "OrderEntity")
                        .WithMany()
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bacchus.Common.Entities.WineEntity", null)
                        .WithMany("OrdersWines")
                        .HasForeignKey("WineEntityId");

                    b.HasOne("Bacchus.Common.Entities.WineEntity", "WineEntity")
                        .WithMany()
                        .HasForeignKey("WineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OrderEntity");

                    b.Navigation("WineEntity");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.SupplierEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId");

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.SupplierWineEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.SupplierEntity", null)
                        .WithMany("SuppliersWines")
                        .HasForeignKey("SupplierEntityId");

                    b.HasOne("Bacchus.Common.Entities.SupplierEntity", "SupplierEntity")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bacchus.Common.Entities.WineEntity", null)
                        .WithMany("SuppliersWines")
                        .HasForeignKey("WineEntityId");

                    b.HasOne("Bacchus.Common.Entities.WineEntity", "WineEntity")
                        .WithMany()
                        .HasForeignKey("WineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("SupplierEntity");

                    b.Navigation("WineEntity");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.UserRoleEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.RoleEntity", "Role")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bacchus.Common.Entities.UserEntity", null)
                        .WithMany("UsersRoles")
                        .HasForeignKey("UserEntityId");

                    b.HasOne("Bacchus.Common.Entities.UserEntity", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Role");

                    b.Navigation("User");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.WineEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.WineFamilyEntity", "Family")
                        .WithMany()
                        .HasForeignKey("FamilyId");

                    b.HasOne("Bacchus.Common.Entities.SupplierEntity", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId");

                    b.Navigation("Family");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderEntity", b =>
                {
                    b.Navigation("OrdersWines");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.SupplierEntity", b =>
                {
                    b.Navigation("SuppliersWines");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.UserEntity", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");

                    b.Navigation("UsersRoles");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.WineEntity", b =>
                {
                    b.Navigation("OrdersWines");

                    b.Navigation("SuppliersWines");
                });
#pragma warning restore 612, 618
        }
    }
}
