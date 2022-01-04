using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace svietnamAPI.Infras.Data.DatabaseContext.Migrations
{
    public partial class fcategorycrudinit : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DocumentTypes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    Extension = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    MimeType = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DocumentTypes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Documents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
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
                name: "Categories",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    Slug = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    IsRoot = table.Column<bool>(type: "Bit", nullable: false),
                    ParentId = table.Column<int>(type: "Int", nullable: true),
                    ChildrenCount = table.Column<int>(type: "Int", nullable: false),
                    ProductCount = table.Column<int>(type: "Int", nullable: false),
                    Description = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    ShortDescription = table.Column<string>(type: "Nvarchar(3000)", maxLength: 3000, nullable: true),
                    BaseImageId = table.Column<int>(type: "int", nullable: false),
                    ThumbnailImageId = table.Column<int>(type: "Int", nullable: false),
                    IsEnabled = table.Column<bool>(type: "Bit", nullable: false),
                    IsDeleted = table.Column<bool>(type: "Bit", nullable: false, defaultValue: false),
                    CreatedAt = table.Column<DateTime>(type: "Datetime", nullable: true),
                    CreatedBy = table.Column<int>(type: "Int", nullable: true),
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
                });

            migrationBuilder.CreateIndex(
                name: "IX_Categories_BaseImageId",
                table: "Categories",
                column: "BaseImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Categories_ThumbnailImageId",
                table: "Categories",
                column: "ThumbnailImageId");

            migrationBuilder.CreateIndex(
                name: "IX_Documents_DocumentTypeId",
                table: "Documents",
                column: "DocumentTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Categories");

            migrationBuilder.DropTable(
                name: "Documents");

            migrationBuilder.DropTable(
                name: "DocumentTypes");
        }
    }
}
