﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using QuanLySach.Models;

namespace QuanLySach.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20201113032959_tuan")]
    partial class tuan
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("QuanLySach.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CategoryId")
                        .HasColumnType("int");

                    b.Property<int>("Count")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NameAuthor")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Short_content")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Year")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CategoryId");

                    b.ToTable("Books");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryId = 1,
                            Count = 50,
                            Name = "Bảo Vệ Động Vật",
                            NameAuthor = "Le Van Luyen",
                            Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            Year = 2000
                        },
                        new
                        {
                            Id = 2,
                            CategoryId = 2,
                            Count = 20,
                            Name = "Bảo Vệ thực vật",
                            NameAuthor = "Le Van A",
                            Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            Year = 2000
                        },
                        new
                        {
                            Id = 3,
                            CategoryId = 3,
                            Count = 200,
                            Name = "Bảo Vệ Môi trường",
                            NameAuthor = "Le Van B",
                            Short_content = "Lorem Ipsum is simply dummy text of the printing and typesetting industry. Lorem Ipsum has been the industry's standard dummy text ever since the 1500s",
                            Year = 2000
                        });
                });

            modelBuilder.Entity("QuanLySach.Models.Category", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CategoryName = "Hóa"
                        },
                        new
                        {
                            Id = 2,
                            CategoryName = "Toán"
                        },
                        new
                        {
                            Id = 3,
                            CategoryName = "Sinh"
                        });
                });

            modelBuilder.Entity("QuanLySach.Models.Books", b =>
                {
                    b.HasOne("QuanLySach.Models.Category", "Category")
                        .WithMany("Books")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
