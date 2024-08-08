using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace S5G11_PVFAPP.Migrations
{
    /// <inheritdoc />
    public partial class dbpush : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "customer",
                columns: table => new
                {
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustomerName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CustomerAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CutomerPostalCode = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_customer", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    EmployeeId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SupervisorIdEmployeeId = table.Column<long>(type: "bigint", nullable: true),
                    EmployeeName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmployeeAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_employee_employee_SupervisorIdEmployeeId",
                        column: x => x.SupervisorIdEmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId");
                });

            migrationBuilder.CreateTable(
                name: "product_line",
                columns: table => new
                {
                    ProductLineID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductLineName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product_line", x => x.ProductLineID);
                });

            migrationBuilder.CreateTable(
                name: "raw_material",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MaterialName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaterialStandardCost = table.Column<float>(type: "real", nullable: false),
                    UnitOfMeasure = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_raw_material", x => x.MaterialID);
                });

            migrationBuilder.CreateTable(
                name: "sales_person",
                columns: table => new
                {
                    SalesPersonID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SalesPersonName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPersonTelephone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPersonFax = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales_person", x => x.SalesPersonID);
                });

            migrationBuilder.CreateTable(
                name: "skill",
                columns: table => new
                {
                    SkillID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Skill_descr = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_skill", x => x.SkillID);
                });

            migrationBuilder.CreateTable(
                name: "vendor",
                columns: table => new
                {
                    VendorlID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    VendorAddress = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_vendor", x => x.VendorlID);
                });

            migrationBuilder.CreateTable(
                name: "work_center",
                columns: table => new
                {
                    WorkCenterId = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    WorkCenterName = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_work_center", x => x.WorkCenterId);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "does_business_in",
                columns: table => new
                {
                    TerritoryID = table.Column<long>(type: "bigint", nullable: false),
                    CustomerID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_does_business_in", x => new { x.TerritoryID, x.CustomerID });
                    table.ForeignKey(
                        name: "FK_does_business_in_customer_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    OrderID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order", x => x.OrderID);
                    table.ForeignKey(
                        name: "FK_order_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "CustomerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "product",
                columns: table => new
                {
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductFinish = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ProductStandardPrice = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    ProductLineID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_product", x => x.ProductID);
                    table.ForeignKey(
                        name: "FK_product_product_line_ProductLineID",
                        column: x => x.ProductLineID,
                        principalTable: "product_line",
                        principalColumn: "ProductLineID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "sales_terrotory",
                columns: table => new
                {
                    TerrotoryID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TerrotoryName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SalesPersonID = table.Column<int>(type: "int", nullable: false),
                    CustomerId = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sales_terrotory", x => x.TerrotoryID);
                    table.ForeignKey(
                        name: "FK_sales_terrotory_customer_CustomerId",
                        column: x => x.CustomerId,
                        principalTable: "customer",
                        principalColumn: "CustomerId");
                    table.ForeignKey(
                        name: "FK_sales_terrotory_sales_person_SalesPersonID",
                        column: x => x.SalesPersonID,
                        principalTable: "sales_person",
                        principalColumn: "SalesPersonID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "has_skill",
                columns: table => new
                {
                    SkillID = table.Column<long>(type: "bigint", nullable: false),
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_has_skill", x => new { x.SkillID, x.EmployeeID });
                    table.ForeignKey(
                        name: "FK_has_skill_employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_has_skill_skill_SkillID",
                        column: x => x.SkillID,
                        principalTable: "skill",
                        principalColumn: "SkillID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "supplies",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    VendorlID = table.Column<long>(type: "bigint", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    SupplyUnitPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_supplies", x => x.Id);
                    table.ForeignKey(
                        name: "FK_supplies_raw_material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "raw_material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_supplies_vendor_VendorlID",
                        column: x => x.VendorlID,
                        principalTable: "vendor",
                        principalColumn: "VendorlID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "VendorRawMaterial",
                columns: table => new
                {
                    VendorId = table.Column<long>(type: "bigint", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    SupplyUnitPrice = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_VendorRawMaterial", x => new { x.VendorId, x.MaterialID });
                    table.ForeignKey(
                        name: "FK_VendorRawMaterial_raw_material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "raw_material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_VendorRawMaterial_vendor_VendorId",
                        column: x => x.VendorId,
                        principalTable: "vendor",
                        principalColumn: "VendorlID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "works_in",
                columns: table => new
                {
                    EmployeeID = table.Column<long>(type: "bigint", nullable: false),
                    WorkCenterID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.ForeignKey(
                        name: "FK_works_in_employee_EmployeeID",
                        column: x => x.EmployeeID,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_works_in_work_center_WorkCenterID",
                        column: x => x.WorkCenterID,
                        principalTable: "work_center",
                        principalColumn: "WorkCenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "order_line",
                columns: table => new
                {
                    OrderLineID = table.Column<long>(type: "bigint", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    OrderID = table.Column<long>(type: "bigint", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false),
                    OrderedQuantity = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_order_line", x => x.OrderLineID);
                    table.ForeignKey(
                        name: "FK_order_line_order_OrderID",
                        column: x => x.OrderID,
                        principalTable: "order",
                        principalColumn: "OrderID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_order_line_product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "produced_in",
                columns: table => new
                {
                    WorkCenterId = table.Column<long>(type: "bigint", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_produced_in", x => new { x.WorkCenterId, x.ProductID });
                    table.ForeignKey(
                        name: "FK_produced_in_product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_produced_in_work_center_WorkCenterId",
                        column: x => x.WorkCenterId,
                        principalTable: "work_center",
                        principalColumn: "WorkCenterId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ProductRawMaterial",
                columns: table => new
                {
                    ProductId = table.Column<long>(type: "bigint", nullable: false),
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    RequiredQuantity = table.Column<float>(type: "real", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductRawMaterial", x => new { x.ProductId, x.MaterialID });
                    table.ForeignKey(
                        name: "FK_ProductRawMaterial_product_ProductId",
                        column: x => x.ProductId,
                        principalTable: "product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ProductRawMaterial_raw_material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "raw_material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "uses",
                columns: table => new
                {
                    MaterialID = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_uses", x => new { x.MaterialID, x.ProductID });
                    table.ForeignKey(
                        name: "FK_uses_product_ProductID",
                        column: x => x.ProductID,
                        principalTable: "product",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_uses_raw_material_MaterialID",
                        column: x => x.MaterialID,
                        principalTable: "raw_material",
                        principalColumn: "MaterialID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "SalesTerritoryBusiness",
                columns: table => new
                {
                    TerritoryID = table.Column<long>(type: "bigint", nullable: false),
                    BusinessID = table.Column<long>(type: "bigint", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SalesTerritoryBusiness", x => new { x.TerritoryID, x.BusinessID });
                    table.ForeignKey(
                        name: "FK_SalesTerritoryBusiness_does_business_in_TerritoryID_BusinessID",
                        columns: x => new { x.TerritoryID, x.BusinessID },
                        principalTable: "does_business_in",
                        principalColumns: new[] { "TerritoryID", "CustomerID" },
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_SalesTerritoryBusiness_sales_terrotory_TerritoryID",
                        column: x => x.TerritoryID,
                        principalTable: "sales_terrotory",
                        principalColumn: "TerrotoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_does_business_in_CustomerID",
                table: "does_business_in",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_employee_SupervisorIdEmployeeId",
                table: "employee",
                column: "SupervisorIdEmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_has_skill_EmployeeID",
                table: "has_skill",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_order_CustomerId",
                table: "order",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_order_line_OrderID",
                table: "order_line",
                column: "OrderID");

            migrationBuilder.CreateIndex(
                name: "IX_order_line_ProductID",
                table: "order_line",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_produced_in_ProductID",
                table: "produced_in",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_product_ProductLineID",
                table: "product",
                column: "ProductLineID");

            migrationBuilder.CreateIndex(
                name: "IX_ProductRawMaterial_MaterialID",
                table: "ProductRawMaterial",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_sales_terrotory_CustomerId",
                table: "sales_terrotory",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_sales_terrotory_SalesPersonID",
                table: "sales_terrotory",
                column: "SalesPersonID");

            migrationBuilder.CreateIndex(
                name: "IX_supplies_MaterialID",
                table: "supplies",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_supplies_VendorlID",
                table: "supplies",
                column: "VendorlID");

            migrationBuilder.CreateIndex(
                name: "IX_uses_ProductID",
                table: "uses",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_VendorRawMaterial_MaterialID",
                table: "VendorRawMaterial",
                column: "MaterialID");

            migrationBuilder.CreateIndex(
                name: "IX_works_in_EmployeeID",
                table: "works_in",
                column: "EmployeeID");

            migrationBuilder.CreateIndex(
                name: "IX_works_in_WorkCenterID",
                table: "works_in",
                column: "WorkCenterID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "has_skill");

            migrationBuilder.DropTable(
                name: "order_line");

            migrationBuilder.DropTable(
                name: "produced_in");

            migrationBuilder.DropTable(
                name: "ProductRawMaterial");

            migrationBuilder.DropTable(
                name: "SalesTerritoryBusiness");

            migrationBuilder.DropTable(
                name: "supplies");

            migrationBuilder.DropTable(
                name: "uses");

            migrationBuilder.DropTable(
                name: "VendorRawMaterial");

            migrationBuilder.DropTable(
                name: "works_in");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "skill");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "does_business_in");

            migrationBuilder.DropTable(
                name: "sales_terrotory");

            migrationBuilder.DropTable(
                name: "product");

            migrationBuilder.DropTable(
                name: "raw_material");

            migrationBuilder.DropTable(
                name: "vendor");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "work_center");

            migrationBuilder.DropTable(
                name: "customer");

            migrationBuilder.DropTable(
                name: "sales_person");

            migrationBuilder.DropTable(
                name: "product_line");
        }
    }
}
