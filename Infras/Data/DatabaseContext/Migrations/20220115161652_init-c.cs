using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace svietnamAPI.Infras.Data.DatabaseContext.Migrations
{
    public partial class initc : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Core_Countries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Countries", x => x.Id);
                    table.UniqueConstraint("AK_Core_Countries_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_Countries_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_Countries_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Core_DataTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    BackendName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_DataTypes", x => x.Id);
                    table.UniqueConstraint("AK_Core_DataTypes_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_DataTypes_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_DataTypes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Core_DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    Extension = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: true),
                    MimeType = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_DocumentTypes", x => x.Id);
                    table.UniqueConstraint("AK_Core_DocumentTypes_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_DocumentTypes_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_DocumentTypes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Core_EntityStatuses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_EntityStatuses", x => x.Id);
                    table.UniqueConstraint("AK_Core_EntityStatuses_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_EntityStatuses_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_EntityStatuses_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Core_EntityTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    IsEavEntity = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_EntityTypes", x => x.Id);
                    table.UniqueConstraint("AK_Core_EntityTypes_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_EntityTypes_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_EntityTypes_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Eav_EavAttributeGroups",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eav_EavAttributeGroups", x => x.Id);
                    table.UniqueConstraint("AK_Eav_EavAttributeGroups_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Eav_EavAttributeGroups_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Eav_EavAttributeGroups_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Eav_EavAttributeSets",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eav_EavAttributeSets", x => x.Id);
                    table.UniqueConstraint("AK_Eav_EavAttributeSets_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Eav_EavAttributeSets_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Eav_EavAttributeSets_Name", x => x.Name);
                });

            migrationBuilder.CreateTable(
                name: "Core_Provinces",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Provinces", x => x.Id);
                    table.UniqueConstraint("AK_Core_Provinces_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_Provinces_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_Provinces_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Core_Provinces_Core_Countries_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Core_Countries",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Auth_Users",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    Salt = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    HashedPassword = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    BirthDay = table.Column<DateTime>(type: "Date", nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_Users", x => x.Id);
                    table.UniqueConstraint("AK_Auth_Users_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Auth_Users_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Auth_Users_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Auth_Users_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: true),
                    Title = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    Location = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    Url = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    Desciption = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    DocumentTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Documents", x => x.Id);
                    table.UniqueConstraint("AK_Core_Documents_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_Documents_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_Documents_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Core_Documents_Core_DocumentTypes_DocumentTypeId",
                        column: x => x.DocumentTypeId,
                        principalTable: "Core_DocumentTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Core_Documents_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eav_EavAttributes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    IsRequired = table.Column<bool>(type: "bit", nullable: false),
                    DataTypeId = table.Column<int>(type: "int", nullable: false),
                    EntityTypeId = table.Column<int>(type: "int", nullable: false),
                    EavAttributeGroupId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true),
                    EavAttributeGroupId1 = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eav_EavAttributes", x => x.Id);
                    table.UniqueConstraint("AK_Eav_EavAttributes_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Eav_EavAttributes_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Eav_EavAttributes_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributes_Core_DataTypes_DataTypeId",
                        column: x => x.DataTypeId,
                        principalTable: "Core_DataTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributes_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributes_Core_EntityTypes_EntityTypeId",
                        column: x => x.EntityTypeId,
                        principalTable: "Core_EntityTypes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributes_Eav_EavAttributeGroups_EavAttributeGroupId",
                        column: x => x.EavAttributeGroupId,
                        principalTable: "Eav_EavAttributeGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributes_Eav_EavAttributeGroups_EavAttributeGroupId1",
                        column: x => x.EavAttributeGroupId1,
                        principalTable: "Eav_EavAttributeGroups",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_Districts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Districts", x => x.Id);
                    table.UniqueConstraint("AK_Core_Districts_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_Districts_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_Districts_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Core_Districts_Core_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Core_Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_GlobalProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    ShortDescription = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    IsRoot = table.Column<bool>(type: "bit", nullable: false),
                    IsLeaf = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    ChildrenCount = table.Column<int>(type: "int", nullable: false),
                    ProductsCount = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    BaseImageId = table.Column<int>(type: "int", nullable: false),
                    ThumbnailImageId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_GlobalProductCategories", x => x.Id);
                    table.UniqueConstraint("AK_Catalog_GlobalProductCategories_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Catalog_GlobalProductCategories_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Catalog_GlobalProductCategories_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Catalog_GlobalProductCategories_Catalog_GlobalProductCategories_ParentId",
                        column: x => x.ParentId,
                        principalTable: "Catalog_GlobalProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_GlobalProductCategories_Core_Documents_BaseImageId",
                        column: x => x.BaseImageId,
                        principalTable: "Core_Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_GlobalProductCategories_Core_Documents_ThumbnailImageId",
                        column: x => x.ThumbnailImageId,
                        principalTable: "Core_Documents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_GlobalProductCategories_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eav_EavAttributeEavAttributeSetMappings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    EavAttributeId = table.Column<int>(type: "int", nullable: false),
                    EavAttributeSetId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eav_EavAttributeEavAttributeSetMappings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributeEavAttributeSetMappings_Eav_EavAttributes_EavAttributeId",
                        column: x => x.EavAttributeId,
                        principalTable: "Eav_EavAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributeEavAttributeSetMappings_Eav_EavAttributeSets_EavAttributeSetId",
                        column: x => x.EavAttributeSetId,
                        principalTable: "Eav_EavAttributeSets",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Eav_EavAttributeValues",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    EavAttributeId = table.Column<int>(type: "int", nullable: false),
                    ValueToString = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Eav_EavAttributeValues", x => x.Id);
                    table.UniqueConstraint("AK_Eav_EavAttributeValues_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributeValues_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Eav_EavAttributeValues_Eav_EavAttributes_EavAttributeId",
                        column: x => x.EavAttributeId,
                        principalTable: "Eav_EavAttributes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_Communes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(3000)", maxLength: 3000, nullable: true),
                    DistrictId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Communes", x => x.Id);
                    table.UniqueConstraint("AK_Core_Communes_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_Communes_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_Communes_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Core_Communes_Core_Districts_DistrictId",
                        column: x => x.DistrictId,
                        principalTable: "Core_Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Core_Addresses",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    ContactName = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    PhoneNumber = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    AddressLine1 = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    AddressLine2 = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    ZipCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true, defaultValue: "False"),
                    CommuneId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Core_Addresses", x => x.Id);
                    table.UniqueConstraint("AK_Core_Addresses_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Core_Addresses_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Core_Addresses_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Core_Addresses_Core_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Core_Communes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Auth_AddressBooks",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Auth_AddressBooks", x => x.Id);
                    table.UniqueConstraint("AK_Auth_AddressBooks_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_Auth_AddressBooks_Auth_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Auth_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Auth_AddressBooks_Core_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Core_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Manufacturers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Manufacturers", x => x.Id);
                    table.UniqueConstraint("AK_Catalog_Manufacturers_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Catalog_Manufacturers_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Catalog_Manufacturers_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Catalog_Manufacturers_Core_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Core_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_Manufacturers_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Suppliers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Suppliers", x => x.Id);
                    table.UniqueConstraint("AK_Catalog_Suppliers_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Catalog_Suppliers_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Catalog_Suppliers_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Catalog_Suppliers_Core_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Core_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_Suppliers_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineStores_Stores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: true),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    Email = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    PhoneNumber = table.Column<string>(type: "Varchar(20)", maxLength: 20, nullable: true),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineStores_Stores", x => x.Id);
                    table.UniqueConstraint("AK_OnlineStores_Stores_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_OnlineStores_Stores_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_OnlineStores_Stores_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_OnlineStores_Stores_Core_Addresses_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Core_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineStores_Stores_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_Products",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: true),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    SKU = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    ShortDescription = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: true),
                    LeafCategoryId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    ItemsCount = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    ManufacturerId = table.Column<int>(type: "int", nullable: false),
                    SupplierId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_Products", x => x.Id);
                    table.UniqueConstraint("AK_Catalog_Products_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Catalog_Products_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Catalog_Products_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Catalog_Products_Catalog_GlobalProductCategories_LeafCategoryId",
                        column: x => x.LeafCategoryId,
                        principalTable: "Catalog_GlobalProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_Products_Catalog_Manufacturers_ManufacturerId",
                        column: x => x.ManufacturerId,
                        principalTable: "Catalog_Manufacturers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_Products_Catalog_Suppliers_SupplierId",
                        column: x => x.SupplierId,
                        principalTable: "Catalog_Suppliers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_Products_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_Products_OnlineStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "OnlineStores_Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Logistics_ShippingTableRates",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    CommuneId = table.Column<int>(type: "int", nullable: true),
                    DistricId = table.Column<int>(type: "int", nullable: true),
                    ProvinceId = table.Column<int>(type: "int", nullable: true),
                    MinOrderSubTotal = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    ShippingPrice = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    Description = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Logistics_ShippingTableRates", x => x.Id);
                    table.UniqueConstraint("AK_Logistics_ShippingTableRates_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_Logistics_ShippingTableRates_Core_Communes_CommuneId",
                        column: x => x.CommuneId,
                        principalTable: "Core_Communes",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logistics_ShippingTableRates_Core_Districts_DistricId",
                        column: x => x.DistricId,
                        principalTable: "Core_Districts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logistics_ShippingTableRates_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logistics_ShippingTableRates_Core_Provinces_ProvinceId",
                        column: x => x.ProvinceId,
                        principalTable: "Core_Provinces",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Logistics_ShippingTableRates_OnlineStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "OnlineStores_Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineOrders_Orders",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    IsRoot = table.Column<bool>(type: "bit", nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false),
                    BillingAddressingId = table.Column<int>(type: "int", nullable: false),
                    SubTotal = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    ShippingPrice = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    OrderTotal = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    OrderNote = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineOrders_Orders", x => x.Id);
                    table.UniqueConstraint("AK_OnlineOrders_Orders_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_Orders_Auth_Users_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Auth_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_Orders_Core_Addresses_BillingAddressingId",
                        column: x => x.BillingAddressingId,
                        principalTable: "Core_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_Orders_Core_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Core_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_Orders_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_Orders_OnlineOrders_Orders_ParentId",
                        column: x => x.ParentId,
                        principalTable: "OnlineOrders_Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_Orders_OnlineStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "OnlineStores_Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineOrders_ShoppingCarts",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    ParentId = table.Column<int>(type: "int", nullable: true),
                    BuyerId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: true),
                    ShippingAddressId = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartNote = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineOrders_ShoppingCarts", x => x.Id);
                    table.UniqueConstraint("AK_OnlineOrders_ShoppingCarts_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCarts_Auth_Users_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Auth_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCarts_Core_Addresses_ShippingAddressId",
                        column: x => x.ShippingAddressId,
                        principalTable: "Core_Addresses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCarts_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCarts_OnlineOrders_ShoppingCarts_ParentId",
                        column: x => x.ParentId,
                        principalTable: "OnlineOrders_ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCarts_OnlineStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "OnlineStores_Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineStores_StoreProductCategories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    GlobalProductCategoryId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineStores_StoreProductCategories", x => x.Id);
                    table.UniqueConstraint("AK_OnlineStores_StoreProductCategories_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_OnlineStores_StoreProductCategories_Catalog_GlobalProductCategories_GlobalProductCategoryId",
                        column: x => x.GlobalProductCategoryId,
                        principalTable: "Catalog_GlobalProductCategories",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineStores_StoreProductCategories_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineStores_StoreProductCategories_OnlineStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "OnlineStores_Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineStores_StoreSellers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(100)", maxLength: 100, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    UserId = table.Column<int>(type: "int", nullable: false),
                    StoreId = table.Column<int>(type: "int", nullable: false),
                    IsStoreOwner = table.Column<bool>(type: "bit", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineStores_StoreSellers", x => x.Id);
                    table.UniqueConstraint("AK_OnlineStores_StoreSellers_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_OnlineStores_StoreSellers_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_OnlineStores_StoreSellers_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_OnlineStores_StoreSellers_Auth_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Auth_Users",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineStores_StoreSellers_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineStores_StoreSellers_OnlineStores_Stores_StoreId",
                        column: x => x.StoreId,
                        principalTable: "OnlineStores_Stores",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ProductItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    Name = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: false),
                    DisplayName = table.Column<string>(type: "Nvarchar(1000)", maxLength: 1000, nullable: false),
                    Slug = table.Column<string>(type: "Varchar(1000)", maxLength: 1000, nullable: true),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    SKU = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    Description = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    ProductId = table.Column<int>(type: "int", nullable: false),
                    ProductItemPrice = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OutOfStockThreshold = table.Column<int>(type: "int", nullable: false),
                    NotifyForQuantityBelow = table.Column<int>(type: "int", nullable: false),
                    MinQtyAllowedInShoppingCart = table.Column<int>(type: "int", nullable: false),
                    MaxQtyAllowedInShoppingCart = table.Column<int>(type: "int", nullable: false),
                    DisplayOrder = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ProductItems", x => x.Id);
                    table.UniqueConstraint("AK_Catalog_ProductItems_DisplayName", x => x.DisplayName);
                    table.UniqueConstraint("AK_Catalog_ProductItems_GlobalCode", x => x.GlobalCode);
                    table.UniqueConstraint("AK_Catalog_ProductItems_Name", x => x.Name);
                    table.ForeignKey(
                        name: "FK_Catalog_ProductItems_Catalog_Products_ProductId",
                        column: x => x.ProductId,
                        principalTable: "Catalog_Products",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_ProductItems_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Payments_Payments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    PaymentFee = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    FailureMessage = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payments_Payments", x => x.Id);
                    table.UniqueConstraint("AK_Payments_Payments_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_Payments_Payments_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Payments_Payments_OnlineOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OnlineOrders_Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Catalog_ProductItemDetails",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    EavAttributeValueId = table.Column<int>(type: "int", nullable: false),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Catalog_ProductItemDetails", x => x.Id);
                    table.UniqueConstraint("AK_Catalog_ProductItemDetails_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_Catalog_ProductItemDetails_Catalog_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "Catalog_ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_ProductItemDetails_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Catalog_ProductItemDetails_Eav_EavAttributeValues_EavAttributeValueId",
                        column: x => x.EavAttributeValueId,
                        principalTable: "Eav_EavAttributeValues",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineOrders_OrderItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    StoreCode = table.Column<string>(type: "Varchar(100)", maxLength: 100, nullable: true),
                    OrderId = table.Column<int>(type: "int", nullable: false),
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    ProductItemPrice = table.Column<decimal>(type: "Decimal(19,2)", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    OrderItemNote = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineOrders_OrderItems", x => x.Id);
                    table.UniqueConstraint("AK_OnlineOrders_OrderItems_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_OrderItems_Catalog_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "Catalog_ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_OrderItems_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_OrderItems_OnlineOrders_Orders_OrderId",
                        column: x => x.OrderId,
                        principalTable: "OnlineOrders_Orders",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "OnlineOrders_ShoppingCartItems",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "100001, 100001"),
                    GlobalCode = table.Column<string>(type: "Varchar(12)", maxLength: 12, nullable: false),
                    ShoppingCartId = table.Column<int>(type: "int", nullable: false),
                    ProductItemId = table.Column<int>(type: "int", nullable: false),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ShoppingCartItemNote = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    EntityStatusId = table.Column<int>(type: "int", nullable: false),
                    IsDeleted = table.Column<bool>(type: "bit", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "int", nullable: true),
                    UpdatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    UpdatedBy = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OnlineOrders_ShoppingCartItems", x => x.Id);
                    table.UniqueConstraint("AK_OnlineOrders_ShoppingCartItems_GlobalCode", x => x.GlobalCode);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCartItems_Catalog_ProductItems_ProductItemId",
                        column: x => x.ProductItemId,
                        principalTable: "Catalog_ProductItems",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCartItems_Core_EntityStatuses_EntityStatusId",
                        column: x => x.EntityStatusId,
                        principalTable: "Core_EntityStatuses",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_OnlineOrders_ShoppingCartItems_OnlineOrders_ShoppingCarts_ShoppingCartId",
                        column: x => x.ShoppingCartId,
                        principalTable: "OnlineOrders_ShoppingCarts",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Auth_AddressBooks_AddressId",
                table: "Auth_AddressBooks",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Auth_AddressBooks_UserId",
                table: "Auth_AddressBooks",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Auth_Users_EntityStatusId",
                table: "Auth_Users",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_GlobalProductCategories_BaseImageId",
                table: "Catalog_GlobalProductCategories",
                column: "BaseImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_GlobalProductCategories_EntityStatusId",
                table: "Catalog_GlobalProductCategories",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_GlobalProductCategories_ParentId",
                table: "Catalog_GlobalProductCategories",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_GlobalProductCategories_ThumbnailImageId",
                table: "Catalog_GlobalProductCategories",
                column: "ThumbnailImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Manufacturers_AddressId",
                table: "Catalog_Manufacturers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Manufacturers_EntityStatusId",
                table: "Catalog_Manufacturers",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_ProductItemDetails_EavAttributeValueId",
                table: "Catalog_ProductItemDetails",
                column: "EavAttributeValueId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_ProductItemDetails_EntityStatusId",
                table: "Catalog_ProductItemDetails",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_ProductItemDetails_ProductItemId",
                table: "Catalog_ProductItemDetails",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_ProductItems_EntityStatusId",
                table: "Catalog_ProductItems",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_ProductItems_ProductId",
                table: "Catalog_ProductItems",
                column: "ProductId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Products_EntityStatusId",
                table: "Catalog_Products",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Products_LeafCategoryId",
                table: "Catalog_Products",
                column: "LeafCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Products_ManufacturerId",
                table: "Catalog_Products",
                column: "ManufacturerId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Products_StoreId",
                table: "Catalog_Products",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Products_SupplierId",
                table: "Catalog_Products",
                column: "SupplierId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Suppliers_AddressId",
                table: "Catalog_Suppliers",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_Catalog_Suppliers_EntityStatusId",
                table: "Catalog_Suppliers",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Addresses_CommuneId",
                table: "Core_Addresses",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Communes_DistrictId",
                table: "Core_Communes",
                column: "DistrictId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Districts_ProvinceId",
                table: "Core_Districts",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Documents_DocumentTypeId",
                table: "Core_Documents",
                column: "DocumentTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Documents_EntityStatusId",
                table: "Core_Documents",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Core_Provinces_CountryId",
                table: "Core_Provinces",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributeEavAttributeSetMappings_EavAttributeId",
                table: "Eav_EavAttributeEavAttributeSetMappings",
                column: "EavAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributeEavAttributeSetMappings_EavAttributeSetId",
                table: "Eav_EavAttributeEavAttributeSetMappings",
                column: "EavAttributeSetId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributes_DataTypeId",
                table: "Eav_EavAttributes",
                column: "DataTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributes_EavAttributeGroupId",
                table: "Eav_EavAttributes",
                column: "EavAttributeGroupId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributes_EavAttributeGroupId1",
                table: "Eav_EavAttributes",
                column: "EavAttributeGroupId1");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributes_EntityStatusId",
                table: "Eav_EavAttributes",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributes_EntityTypeId",
                table: "Eav_EavAttributes",
                column: "EntityTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributeValues_EavAttributeId",
                table: "Eav_EavAttributeValues",
                column: "EavAttributeId");

            migrationBuilder.CreateIndex(
                name: "IX_Eav_EavAttributeValues_EntityStatusId",
                table: "Eav_EavAttributeValues",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_ShippingTableRates_CommuneId",
                table: "Logistics_ShippingTableRates",
                column: "CommuneId");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_ShippingTableRates_DistricId",
                table: "Logistics_ShippingTableRates",
                column: "DistricId");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_ShippingTableRates_EntityStatusId",
                table: "Logistics_ShippingTableRates",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_ShippingTableRates_ProvinceId",
                table: "Logistics_ShippingTableRates",
                column: "ProvinceId");

            migrationBuilder.CreateIndex(
                name: "IX_Logistics_ShippingTableRates_StoreId",
                table: "Logistics_ShippingTableRates",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_OrderItems_EntityStatusId",
                table: "OnlineOrders_OrderItems",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_OrderItems_OrderId",
                table: "OnlineOrders_OrderItems",
                column: "OrderId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_OrderItems_ProductItemId",
                table: "OnlineOrders_OrderItems",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_Orders_BillingAddressingId",
                table: "OnlineOrders_Orders",
                column: "BillingAddressingId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_Orders_EntityStatusId",
                table: "OnlineOrders_Orders",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_Orders_ParentId",
                table: "OnlineOrders_Orders",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_Orders_ShippingAddressId",
                table: "OnlineOrders_Orders",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_Orders_StoreId",
                table: "OnlineOrders_Orders",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_ShoppingCartItems_EntityStatusId",
                table: "OnlineOrders_ShoppingCartItems",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_ShoppingCartItems_ProductItemId",
                table: "OnlineOrders_ShoppingCartItems",
                column: "ProductItemId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_ShoppingCartItems_ShoppingCartId",
                table: "OnlineOrders_ShoppingCartItems",
                column: "ShoppingCartId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_ShoppingCarts_EntityStatusId",
                table: "OnlineOrders_ShoppingCarts",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_ShoppingCarts_ParentId",
                table: "OnlineOrders_ShoppingCarts",
                column: "ParentId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_ShoppingCarts_ShippingAddressId",
                table: "OnlineOrders_ShoppingCarts",
                column: "ShippingAddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineOrders_ShoppingCarts_StoreId",
                table: "OnlineOrders_ShoppingCarts",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_StoreProductCategories_EntityStatusId",
                table: "OnlineStores_StoreProductCategories",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_StoreProductCategories_GlobalProductCategoryId",
                table: "OnlineStores_StoreProductCategories",
                column: "GlobalProductCategoryId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_StoreProductCategories_StoreId",
                table: "OnlineStores_StoreProductCategories",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_Stores_AddressId",
                table: "OnlineStores_Stores",
                column: "AddressId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_Stores_EntityStatusId",
                table: "OnlineStores_Stores",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_StoreSellers_EntityStatusId",
                table: "OnlineStores_StoreSellers",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_StoreSellers_StoreId",
                table: "OnlineStores_StoreSellers",
                column: "StoreId");

            migrationBuilder.CreateIndex(
                name: "IX_OnlineStores_StoreSellers_UserId",
                table: "OnlineStores_StoreSellers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Payments_EntityStatusId",
                table: "Payments_Payments",
                column: "EntityStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_Payments_Payments_OrderId",
                table: "Payments_Payments",
                column: "OrderId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Auth_AddressBooks");

            migrationBuilder.DropTable(
                name: "Catalog_ProductItemDetails");

            migrationBuilder.DropTable(
                name: "Eav_EavAttributeEavAttributeSetMappings");

            migrationBuilder.DropTable(
                name: "Logistics_ShippingTableRates");

            migrationBuilder.DropTable(
                name: "OnlineOrders_OrderItems");

            migrationBuilder.DropTable(
                name: "OnlineOrders_ShoppingCartItems");

            migrationBuilder.DropTable(
                name: "OnlineStores_StoreProductCategories");

            migrationBuilder.DropTable(
                name: "OnlineStores_StoreSellers");

            migrationBuilder.DropTable(
                name: "Payments_Payments");

            migrationBuilder.DropTable(
                name: "Eav_EavAttributeValues");

            migrationBuilder.DropTable(
                name: "Eav_EavAttributeSets");

            migrationBuilder.DropTable(
                name: "Catalog_ProductItems");

            migrationBuilder.DropTable(
                name: "OnlineOrders_ShoppingCarts");

            migrationBuilder.DropTable(
                name: "OnlineOrders_Orders");

            migrationBuilder.DropTable(
                name: "Eav_EavAttributes");

            migrationBuilder.DropTable(
                name: "Catalog_Products");

            migrationBuilder.DropTable(
                name: "Auth_Users");

            migrationBuilder.DropTable(
                name: "Core_DataTypes");

            migrationBuilder.DropTable(
                name: "Core_EntityTypes");

            migrationBuilder.DropTable(
                name: "Eav_EavAttributeGroups");

            migrationBuilder.DropTable(
                name: "Catalog_GlobalProductCategories");

            migrationBuilder.DropTable(
                name: "Catalog_Manufacturers");

            migrationBuilder.DropTable(
                name: "Catalog_Suppliers");

            migrationBuilder.DropTable(
                name: "OnlineStores_Stores");

            migrationBuilder.DropTable(
                name: "Core_Documents");

            migrationBuilder.DropTable(
                name: "Core_Addresses");

            migrationBuilder.DropTable(
                name: "Core_DocumentTypes");

            migrationBuilder.DropTable(
                name: "Core_EntityStatuses");

            migrationBuilder.DropTable(
                name: "Core_Communes");

            migrationBuilder.DropTable(
                name: "Core_Districts");

            migrationBuilder.DropTable(
                name: "Core_Provinces");

            migrationBuilder.DropTable(
                name: "Core_Countries");
        }
    }
}
