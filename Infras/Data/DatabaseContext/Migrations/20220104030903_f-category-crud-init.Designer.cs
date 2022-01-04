﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using svietnamAPI.Infras.Data.DatabaseContext;

namespace svietnamAPI.Infras.Data.DatabaseContext.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20220104030903_f-category-crud-init")]
    partial class fcategorycrudinit
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.0");

            modelBuilder.Entity("svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<int>("BaseImageId")
                        .HasColumnType("int");

                    b.Property<int>("ChildrenCount")
                        .HasColumnType("Int");

                    b.Property<DateTime?>("CreatedAt")
                        .HasColumnType("Datetime");

                    b.Property<int?>("CreatedBy")
                        .HasColumnType("Int");

                    b.Property<string>("Description")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<bool>("IsEnabled")
                        .HasColumnType("Bit");

                    b.Property<bool>("IsRoot")
                        .HasColumnType("Bit");

                    b.Property<string>("Name")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<int?>("ParentId")
                        .HasColumnType("Int");

                    b.Property<int>("ProductCount")
                        .HasColumnType("Int");

                    b.Property<string>("ShortDescription")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<string>("Slug")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<int>("ThumbnailImageId")
                        .HasColumnType("Int");

                    b.Property<DateTime?>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.Property<int?>("UpdatedBy")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("BaseImageId");

                    b.HasIndex("ThumbnailImageId");

                    b.ToTable("Categories");
                });

            modelBuilder.Entity("svietnamAPI.Infras.Data.DatabaseContext.Entities.Core.Document", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Desciption")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<int>("DocumentTypeId")
                        .HasColumnType("Int");

                    b.Property<bool>("IsDeleted")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("Bit")
                        .HasDefaultValue(false);

                    b.Property<string>("Location")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<string>("Name")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<string>("Title")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<string>("Url")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.HasKey("Id");

                    b.HasIndex("DocumentTypeId");

                    b.ToTable("Documents");
                });

            modelBuilder.Entity("svietnamAPI.Infras.Data.DatabaseContext.Entities.Core.DocumentType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Extension")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<string>("MimeType")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.Property<string>("Name")
                        .HasMaxLength(3000)
                        .HasColumnType("Nvarchar(3000)");

                    b.HasKey("Id");

                    b.ToTable("DocumentTypes");
                });

            modelBuilder.Entity("svietnamAPI.Infras.Data.DatabaseContext.Entities.Catalog.Category", b =>
                {
                    b.HasOne("svietnamAPI.Infras.Data.DatabaseContext.Entities.Core.Document", "BaseImage")
                        .WithMany()
                        .HasForeignKey("BaseImageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.HasOne("svietnamAPI.Infras.Data.DatabaseContext.Entities.Core.Document", "ThumbnailImage")
                        .WithMany()
                        .HasForeignKey("ThumbnailImageId")
                        .OnDelete(DeleteBehavior.NoAction)
                        .IsRequired();

                    b.Navigation("BaseImage");

                    b.Navigation("ThumbnailImage");
                });

            modelBuilder.Entity("svietnamAPI.Infras.Data.DatabaseContext.Entities.Core.Document", b =>
                {
                    b.HasOne("svietnamAPI.Infras.Data.DatabaseContext.Entities.Core.DocumentType", "DocumentType")
                        .WithMany("Documents")
                        .HasForeignKey("DocumentTypeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("DocumentType");
                });

            modelBuilder.Entity("svietnamAPI.Infras.Data.DatabaseContext.Entities.Core.DocumentType", b =>
                {
                    b.Navigation("Documents");
                });
#pragma warning restore 612, 618
        }
    }
}
