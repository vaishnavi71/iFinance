﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using S5G11_PVFAPP.Models;

#nullable disable

namespace S5G11_PVFAPP.Migrations
{
    [DbContext(typeof(AppDBContext))]
    partial class AppDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasDatabaseName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RoleId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("AccessFailedCount")
                        .HasColumnType("int");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<bool>("EmailConfirmed")
                        .HasColumnType("bit");

                    b.Property<bool>("LockoutEnabled")
                        .HasColumnType("bit");

                    b.Property<DateTimeOffset?>("LockoutEnd")
                        .HasColumnType("datetimeoffset");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.Property<string>("PasswordHash")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("PhoneNumberConfirmed")
                        .HasColumnType("bit");

                    b.Property<string>("SecurityStamp")
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("TwoFactorEnabled")
                        .HasColumnType("bit");

                    b.Property<string>("UserName")
                        .HasMaxLength(256)
                        .HasColumnType("nvarchar(256)");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasDatabaseName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasDatabaseName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("ClaimType")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ClaimValue")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderKey")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ProviderDisplayName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("UserId")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("RoleId")
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles", (string)null);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("LoginProvider")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Value")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens", (string)null);
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Customer", b =>
                {
                    b.Property<long>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("CustomerId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("CustomerId"));

                    b.Property<string>("CustomerAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CustomerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CutomerPostalCode")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("customer");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.DoesBusinessIn", b =>
                {
                    b.Property<long>("TerritoryID")
                        .HasColumnType("bigint")
                        .HasColumnName("TerritoryID");

                    b.Property<long>("CustomerID")
                        .HasColumnType("bigint")
                        .HasColumnName("CustomerID");

                    b.HasKey("TerritoryID", "CustomerID");

                    b.HasIndex("CustomerID");

                    b.ToTable("does_business_in");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Employee", b =>
                {
                    b.Property<long>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("EmployeeId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("EmployeeId"));

                    b.Property<string>("EmployeeAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("EmployeeName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<long?>("SupervisorIdEmployeeId")
                        .HasColumnType("bigint");

                    b.HasKey("EmployeeId");

                    b.HasIndex("SupervisorIdEmployeeId");

                    b.ToTable("employee");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.HasSkill", b =>
                {
                    b.Property<long>("SkillID")
                        .HasColumnType("bigint");

                    b.Property<long>("EmployeeID")
                        .HasColumnType("bigint");

                    b.HasKey("SkillID", "EmployeeID");

                    b.HasIndex("EmployeeID");

                    b.ToTable("has_skill");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Order", b =>
                {
                    b.Property<long>("OrderID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrderID"));

                    b.Property<long>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.HasKey("OrderID");

                    b.HasIndex("CustomerId");

                    b.ToTable("order");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.OrderLine", b =>
                {
                    b.Property<long>("OrderLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("OrderLineID"));

                    b.Property<long>("OrderID")
                        .HasColumnType("bigint")
                        .HasColumnName("OrderID");

                    b.Property<int>("OrderedQuantity")
                        .HasColumnType("int");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint")
                        .HasColumnName("ProductID");

                    b.HasKey("OrderLineID");

                    b.HasIndex("OrderID");

                    b.HasIndex("ProductID");

                    b.ToTable("order_line");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.ProducedIn", b =>
                {
                    b.Property<long>("WorkCenterId")
                        .HasColumnType("bigint")
                        .HasColumnName("WorkCenterId");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint")
                        .HasColumnName("ProductID");

                    b.HasKey("WorkCenterId", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("produced_in");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Product", b =>
                {
                    b.Property<long>("ProductID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("ProductID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductID"));

                    b.Property<string>("ProductDescription")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("ProductFinish")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<long>("ProductLineID")
                        .HasColumnType("bigint");

                    b.Property<decimal>("ProductStandardPrice")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("ProductID");

                    b.HasIndex("ProductLineID");

                    b.ToTable("product");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.ProductLine", b =>
                {
                    b.Property<long>("ProductLineID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("ProductLineID"));

                    b.Property<string>("ProductLineName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("ProductLineID");

                    b.ToTable("product_line");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.ProductRawMaterial", b =>
                {
                    b.Property<long>("ProductId")
                        .HasColumnType("bigint");

                    b.Property<int>("MaterialID")
                        .HasColumnType("int");

                    b.Property<float>("RequiredQuantity")
                        .HasColumnType("real");

                    b.HasKey("ProductId", "MaterialID");

                    b.HasIndex("MaterialID");

                    b.ToTable("ProductRawMaterial");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.RawMaterial", b =>
                {
                    b.Property<int>("MaterialID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MaterialID"));

                    b.Property<string>("MaterialName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<float>("MaterialStandardCost")
                        .HasColumnType("real");

                    b.Property<string>("UnitOfMeasure")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaterialID");

                    b.ToTable("raw_material");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.SalesPerson", b =>
                {
                    b.Property<int>("SalesPersonID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("SalesPersonID"));

                    b.Property<string>("SalesPersonFax")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesPersonName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SalesPersonTelephone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("SalesPersonID");

                    b.ToTable("sales_person");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.SalesTerritory", b =>
                {
                    b.Property<long>("TerrotoryID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("TerrotoryID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("TerrotoryID"));

                    b.Property<long?>("CustomerId")
                        .HasColumnType("bigint");

                    b.Property<int>("SalesPersonID")
                        .HasColumnType("int");

                    b.Property<string>("TerrotoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("TerrotoryID");

                    b.HasIndex("CustomerId");

                    b.HasIndex("SalesPersonID");

                    b.ToTable("sales_terrotory");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.SalesTerritoryBusiness", b =>
                {
                    b.Property<long?>("TerritoryID")
                        .HasColumnType("bigint");

                    b.Property<long?>("BusinessID")
                        .HasColumnType("bigint");

                    b.HasKey("TerritoryID", "BusinessID");

                    b.ToTable("SalesTerritoryBusiness");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Skills", b =>
                {
                    b.Property<long>("SkillID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("SkillID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("SkillID"));

                    b.Property<string>("SkillDescr")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)")
                        .HasColumnName("Skill_descr");

                    b.HasKey("SkillID");

                    b.ToTable("skill");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Supplies", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("MaterialID")
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    b.Property<float>("SupplyUnitPrice")
                        .HasColumnType("real");

                    b.Property<long>("VendorlID")
                        .HasColumnType("bigint")
                        .HasColumnName("VendorlID");

                    b.HasKey("Id");

                    b.HasIndex("MaterialID");

                    b.HasIndex("VendorlID");

                    b.ToTable("supplies");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Uses", b =>
                {
                    b.Property<int>("MaterialID")
                        .HasColumnType("int")
                        .HasColumnName("MaterialID");

                    b.Property<long>("ProductID")
                        .HasColumnType("bigint")
                        .HasColumnName("ProductID");

                    b.HasKey("MaterialID", "ProductID");

                    b.HasIndex("ProductID");

                    b.ToTable("uses");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Vendor", b =>
                {
                    b.Property<long>("VendorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("VendorlID");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("VendorId"));

                    b.Property<string>("VendorAddress")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("VendorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("VendorId");

                    b.ToTable("vendor");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.VendorRawMaterial", b =>
                {
                    b.Property<long>("VendorId")
                        .HasColumnType("bigint");

                    b.Property<int>("MaterialID")
                        .HasColumnType("int");

                    b.Property<float>("SupplyUnitPrice")
                        .HasColumnType("real");

                    b.HasKey("VendorId", "MaterialID");

                    b.HasIndex("MaterialID");

                    b.ToTable("VendorRawMaterial");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.WorkCenter", b =>
                {
                    b.Property<long>("WorkCenterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("bigint")
                        .HasColumnName("WorkCenterId");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<long>("WorkCenterId"));

                    b.Property<string>("WorkCenterName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("WorkCenterId");

                    b.ToTable("work_center");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.WorksIn", b =>
                {
                    b.Property<long>("EmployeeID")
                        .HasColumnType("bigint")
                        .HasColumnName("EmployeeID");

                    b.Property<long>("WorkCenterID")
                        .HasColumnType("bigint")
                        .HasColumnName("WorkCenterID");

                    b.HasIndex("EmployeeID");

                    b.HasIndex("WorkCenterID");

                    b.ToTable("works_in");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.DoesBusinessIn", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Customer", null)
                        .WithMany("DoesBusinessIns")
                        .HasForeignKey("CustomerID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Employee", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Employee", "SupervisorId")
                        .WithMany()
                        .HasForeignKey("SupervisorIdEmployeeId");

                    b.Navigation("SupervisorId");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.HasSkill", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Employee", "Employee")
                        .WithMany("HasSkills")
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.Skills", "Skill")
                        .WithMany()
                        .HasForeignKey("SkillID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("Skill");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Order", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Customer", "CustomerID")
                        .WithMany()
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("CustomerID");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.OrderLine", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Order", "Order")
                        .WithMany()
                        .HasForeignKey("OrderID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.Product", "Product")
                        .WithMany("OrderLines")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Order");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.ProducedIn", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Product", "Product")
                        .WithMany("ProducedIns")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.WorkCenter", "WorkCenter")
                        .WithMany("ProducedIns")
                        .HasForeignKey("WorkCenterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("WorkCenter");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Product", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.ProductLine", "ProductLine")
                        .WithMany("Products")
                        .HasForeignKey("ProductLineID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ProductLine");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.ProductRawMaterial", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.RawMaterial", "RawMaterial")
                        .WithMany("ProductRawMaterials")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.Product", "Product")
                        .WithMany("ProductRawMaterials")
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Product");

                    b.Navigation("RawMaterial");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.SalesTerritory", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Customer", null)
                        .WithMany("SalesTerritories")
                        .HasForeignKey("CustomerId");

                    b.HasOne("S5G11_PVFAPP.Models.SalesPerson", "salesPerson")
                        .WithMany("Territories")
                        .HasForeignKey("SalesPersonID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("salesPerson");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.SalesTerritoryBusiness", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.SalesTerritory", "Territory")
                        .WithMany("SalesTerritoryBusinesses")
                        .HasForeignKey("TerritoryID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.DoesBusinessIn", "Business")
                        .WithMany("SalesTerritoryBusinesses")
                        .HasForeignKey("TerritoryID", "BusinessID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Business");

                    b.Navigation("Territory");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Supplies", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.RawMaterial", "RawMaterial")
                        .WithMany("Supplies")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.Vendor", "Vendor")
                        .WithMany("Supplies")
                        .HasForeignKey("VendorlID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RawMaterial");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Uses", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.RawMaterial", "Material")
                        .WithMany("Uses")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.Product", "Product")
                        .WithMany("Uses")
                        .HasForeignKey("ProductID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Material");

                    b.Navigation("Product");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.VendorRawMaterial", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.RawMaterial", "RawMaterial")
                        .WithMany("VendorRawMaterials")
                        .HasForeignKey("MaterialID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.Vendor", "Vendor")
                        .WithMany("VendorRawMaterials")
                        .HasForeignKey("VendorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("RawMaterial");

                    b.Navigation("Vendor");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.WorksIn", b =>
                {
                    b.HasOne("S5G11_PVFAPP.Models.Employee", "Employee")
                        .WithMany()
                        .HasForeignKey("EmployeeID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("S5G11_PVFAPP.Models.WorkCenter", "WorkCenter")
                        .WithMany()
                        .HasForeignKey("WorkCenterID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Employee");

                    b.Navigation("WorkCenter");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Customer", b =>
                {
                    b.Navigation("DoesBusinessIns");

                    b.Navigation("SalesTerritories");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.DoesBusinessIn", b =>
                {
                    b.Navigation("SalesTerritoryBusinesses");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Employee", b =>
                {
                    b.Navigation("HasSkills");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Product", b =>
                {
                    b.Navigation("OrderLines");

                    b.Navigation("ProducedIns");

                    b.Navigation("ProductRawMaterials");

                    b.Navigation("Uses");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.ProductLine", b =>
                {
                    b.Navigation("Products");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.RawMaterial", b =>
                {
                    b.Navigation("ProductRawMaterials");

                    b.Navigation("Supplies");

                    b.Navigation("Uses");

                    b.Navigation("VendorRawMaterials");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.SalesPerson", b =>
                {
                    b.Navigation("Territories");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.SalesTerritory", b =>
                {
                    b.Navigation("SalesTerritoryBusinesses");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.Vendor", b =>
                {
                    b.Navigation("Supplies");

                    b.Navigation("VendorRawMaterials");
                });

            modelBuilder.Entity("S5G11_PVFAPP.Models.WorkCenter", b =>
                {
                    b.Navigation("ProducedIns");
                });
#pragma warning restore 612, 618
        }
    }
}