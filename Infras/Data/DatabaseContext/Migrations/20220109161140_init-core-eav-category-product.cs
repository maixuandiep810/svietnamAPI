using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace svietnamAPI.Infras.Data.DatabaseContext.Migrations
{
    public partial class initcoreeavcategoryproduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DataTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    BackendName = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DataTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Extension = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    MimeType = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EavAttributeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EavAttributeGroups", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EavAttributeSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EavAttributeSets", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityStatuses", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "EntityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    IsEavEntity = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EntityTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Provinces", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Title = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    Location = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    Url = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    Desciption = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    DocumentTypeId = table.Column<int>(type: "Int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Documents", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Documents_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EavAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EavAttributeGroupId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EavAttributes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EavAttributes_DataTypes_DataTypeId",
                        column: x => x.DataTypeId,
                        principalTable: "DataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EavAttributes_EavAttributeGroups_EavAttributeGroupId",
                        column: x => x.EavAttributeGroupId,
                        principalTable: "EavAttributeGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EavAttributes_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Districts", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Districts_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Provinces",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Description = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    ShortDescription = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    IsRoot = table.Column<bool>(type: "Bit", nullable: false),
                    IsLeaf = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "Int", nullable: true),
                    ChildrenCount = table.Column<int>(type: "Int", nullable: false),
                    ProductsCount = table.Column<int>(type: "Int", nullable: false),
                    BaseImageId = table.Column<int>(type: "int", nullable: false),
                    ThumbnailImageId = table.Column<int>(type: "Int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "Int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Categories", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Categories_Documents_BaseImageId",
                        column: x => x.BaseImageId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Categories_Documents_ThumbnailImageId",
                        column: x => x.ThumbnailImageId,
                        principalTable: "Documents",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Categories_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EavAttributeEavAttributeSetMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EavAttributeId = table.Column<int>(type: "int", nullable: false),
                    EavAttributeSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EavAttributeEavAttributeSetMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EavAttributeEavAttributeSetMappings_EavAttributes_EavAttributeId",
                        column: x => x.EavAttributeId,
                        principalTable: "EavAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_EavAttributeEavAttributeSetMappings_EavAttributeSets_EavAttributeSetId",
                        column: x => x.EavAttributeSetId,
                        principalTable: "EavAttributeSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "EavAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    EavAttributeId = table.Column<int>(type: "int", nullable: false),
                    ValueToString = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_EavAttributeValues", x => x.Id);
                    table.ForeignKey(
                        name: "FK_EavAttributeValues_EavAttributes_EavAttributeId",
                        column: x => x.EavAttributeId,
                        principalTable: "EavAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Communes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Communes", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Communes_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Districts",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    ContactName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    PhoneNumber = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    AddressLine1 = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    AddressLine2 = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    ZipCode = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    CommuneId = table.Column<int>(type: "Int", nullable: false, defaultValue: 0)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Addresses", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Addresses_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Communes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    AddressId = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Manufacturers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Manufacturers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    AddressId = table.Column<int>(type: "Int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Suppliers", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Suppliers_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Addresses",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    SKU = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true),
                    Description = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    ShortDescription = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    LeafCategoryId = table.Column<int>(type: "int", nullable: false),
                    ItemsCount = table.Column<int>(type: "Int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Products_Categories_LeafCategoryId",
                        column: x => x.LeafCategoryId,
                        principalTable: "Categories",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Manufacturers",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Products_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Suppliers",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Code = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true, defaultValue: "False"),
                    SKU = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Qty = table.Column<int>(type: "int", nullable: false),
                    OutOfStockThreshold = table.Column<int>(type: "int", nullable: false),
                    NotifyForQuantityBelow = table.Column<int>(type: "int", nullable: false),
                    MinQtyAllowedInShoppingCart = table.Column<int>(type: "int", nullable: false),
                    MaxQtyAllowedInShoppingCart = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItems", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItems_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "EntityStatuses",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductItems_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Products",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "ProductItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    EavAttributeValueId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ProductItemDetails", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ProductItemDetails_EavAttributeValues_EavAttributeValueId",
                        column: x => x.EavAttributeValueId,
                        principalTable: "EavAttributeValues",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_ProductItemDetails_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "ProductItems",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Addresses_CommuneId",
                table: "Addresses",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BaseImageId",
                table: "Categories",
                column: "BaseImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_EntityStatusId",
                table: "Categories",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ThumbnailImageId",
                table: "Categories",
                column: "ThumbnailImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Communes_DistrictId",
                table: "Communes",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Districts_ProvinceId",
                table: "Districts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EavAttributeEavAttributeSetMappings_EavAttributeId",
                table: "EavAttributeEavAttributeSetMappings",
                column: "EavAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_EavAttributeEavAttributeSetMappings_EavAttributeSetId",
                table: "EavAttributeEavAttributeSetMappings",
                column: "EavAttributeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_EavAttributes_DataTypeId",
                table: "EavAttributes",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EavAttributes_EavAttributeGroupId",
                table: "EavAttributes",
                column: "EavAttributeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_EavAttributes_EntityTypeId",
                table: "EavAttributes",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_EavAttributeValues_EavAttributeId",
                table: "EavAttributeValues",
                column: "EavAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Manufacturers_AddressId",
                table: "Manufacturers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItemDetails_EavAttributeValueId",
                table: "ProductItemDetails",
                column: "EavAttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItemDetails_ProductItemId",
                table: "ProductItemDetails",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_EntityStatusId",
                table: "ProductItems",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_ProductItems_ProductId",
                table: "ProductItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_EntityStatusId",
                table: "Products",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_LeafCategoryId",
                table: "Products",
                column: "LeafCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_ManufacturerId",
                table: "Products",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Products_SupplierId",
                table: "Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Suppliers_AddressId",
                table: "Suppliers",
                column: "AddressId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "EavAttributeEavAttributeSetMappings");

            migrationBuilder.DropTable(
                name: "ProductItemDetails");

            migrationBuilder.DropTable(
                name: "EavAttributeSets");

            migrationBuilder.DropTable(
                name: "EavAttributeValues");

            migrationBuilder.DropTable(
                name: "ProductItems");

            migrationBuilder.DropTable(
                name: "EavAttributes");

            migrationBuilder.DropTable(
                name: "Products");

            migrationBuilder.DropTable(
                name: "DataTypes");

            migrationBuilder.DropTable(
                name: "EavAttributeGroups");

            migrationBuilder.DropTable(
                name: "EntityTypes");

            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Manufacturers");

            migrationBuilder.DropTable(
                name: "Suppliers");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "EntityStatuses");

            migrationBuilder.DropTable(
                name: "Addresses");

            migrationBuilder.DropTable(
                name: "DocumentTypes");

            migrationBuilder.DropTable(
                name: "Communes");

            migrationBuilder.DropTable(
                name: "Districts");

            migrationBuilder.DropTable(
                name: "Provinces");
        }
    }
}
