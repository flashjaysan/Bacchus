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
    [Migration("20221208131139_bigmaj")]
    partial class bigmaj
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Number")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Street")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Addresses", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.GrapeVarietyEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("GrapeVarieties", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("DeliveryAddressId")
                        .HasColumnType("int");

                    b.Property<int>("StatusId")
                        .HasColumnType("int");

                    b.Property<int>("TypeId")
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

            modelBuilder.Entity("Bacchus.Common.Entities.OrderLineEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int?>("OrderEntityId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.Property<int>("WineId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("OrderEntityId");

                    b.HasIndex("WineId");

                    b.ToTable("OrderLines", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderStatusEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
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
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OrderTypes", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.RoleEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("UserEntityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UserEntityId");

                    b.ToTable("Roles", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.SupplierEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("AddressId")
                        .HasColumnType("int");

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePhoneNumber")
                        .HasColumnType("int");

                    b.Property<int>("MobilePhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Website")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("AddressId");

                    b.ToTable("Suppliers", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.UserEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("EmailAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EncryptedPassword")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("HomePhoneNumber")
                        .HasColumnType("int");

                    b.Property<string>("LastName")
                        .IsRequired()
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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.HasIndex("UserId");

                    b.ToTable("UsersRoles", (string)null);
                });

            modelBuilder.Entity("Bacchus.Common.Entities.WineEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Domain")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("FamilyId")
                        .HasColumnType("int");

                    b.Property<int>("GrapeVarietyId")
                        .HasColumnType("int");

                    b.Property<decimal>("PurchasePrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SellingPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<int>("SupplierId")
                        .HasColumnType("int");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("FamilyId");

                    b.HasIndex("GrapeVarietyId");

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
                        .IsRequired()
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
                        .HasForeignKey("DeliveryAddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bacchus.Common.Entities.OrderStatusEntity", "Status")
                        .WithMany()
                        .HasForeignKey("StatusId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bacchus.Common.Entities.OrderTypeEntity", "Type")
                        .WithMany()
                        .HasForeignKey("TypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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

            modelBuilder.Entity("Bacchus.Common.Entities.OrderLineEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.OrderEntity", null)
                        .WithMany("Lines")
                        .HasForeignKey("OrderEntityId");

                    b.HasOne("Bacchus.Common.Entities.WineEntity", "Wine")
                        .WithMany()
                        .HasForeignKey("WineId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Wine");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.RoleEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.UserEntity", null)
                        .WithMany("Roles")
                        .HasForeignKey("UserEntityId");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.SupplierEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.AddressEntity", "Address")
                        .WithMany()
                        .HasForeignKey("AddressId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Address");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.UserRoleEntity", b =>
                {
                    b.HasOne("Bacchus.Common.Entities.RoleEntity", "Role")
                        .WithMany("UserRoles")
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

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
                        .HasForeignKey("FamilyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bacchus.Common.Entities.GrapeVarietyEntity", "GrapeVariety")
                        .WithMany()
                        .HasForeignKey("GrapeVarietyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Bacchus.Common.Entities.SupplierEntity", "Supplier")
                        .WithMany()
                        .HasForeignKey("SupplierId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Family");

                    b.Navigation("GrapeVariety");

                    b.Navigation("Supplier");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.OrderEntity", b =>
                {
                    b.Navigation("Lines");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.RoleEntity", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("Bacchus.Common.Entities.UserEntity", b =>
                {
                    b.Navigation("Addresses");

                    b.Navigation("Orders");

                    b.Navigation("Roles");
                });
#pragma warning restore 612, 618
        }
    }
}
