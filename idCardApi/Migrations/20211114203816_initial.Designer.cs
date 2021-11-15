﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using idCardApp.API.Data;

namespace idCardApi.Migrations
{
    [DbContext(typeof(idCardContext))]
    [Migration("20211114203816_initial")]
    partial class initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.19")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("idCardApi.Models.StudentCourse", b =>
                {
                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.HasKey("StudentEmail", "CourseId");

                    b.HasIndex("CourseId");

                    b.ToTable("StudentCourses");

                    b.HasData(
                        new
                        {
                            StudentEmail = "jaak.metdebroek@student.pxl.be",
                            CourseId = 1
                        });
                });

            modelBuilder.Entity("idCardApp.API.Models.Course", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Courses");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = ".Net Expert"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Java Expert"
                        });
                });

            modelBuilder.Entity("idCardApp.API.Models.Lector", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.ToTable("Lectors");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Email = "kris.hermans@pxl.be",
                            Firstname = "Kris",
                            Name = "Hermans",
                            Role = 1
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 2,
                            Email = "tom.schuyten@pxl.be",
                            Firstname = "Tom",
                            Name = "Schuyten",
                            Role = 1
                        });
                });

            modelBuilder.Entity("idCardApp.API.Models.PEDate", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CourseId");

                    b.ToTable("PEDates");
                });

            modelBuilder.Entity("idCardApp.API.Models.Student", b =>
                {
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            Email = "jaak.metdebroek@student.pxl.be",
                            Firstname = "Jaak",
                            Id = 1,
                            Name = "Metdebroek",
                            Role = 0
                        },
                        new
                        {
                            Email = "jos.indebroek@student.pxl.be",
                            Firstname = "Jos",
                            Id = 2,
                            Name = "Indebroek",
                            Role = 0
                        },
                        new
                        {
                            Email = "jef.vandebroek@student.pxl.be",
                            Firstname = "Jef",
                            Id = 3,
                            Name = "Vandebroek",
                            Role = 0
                        });
                });

            modelBuilder.Entity("idCardApi.Models.StudentCourse", b =>
                {
                    b.HasOne("idCardApp.API.Models.Course", "Course")
                        .WithMany("Students")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("idCardApp.API.Models.Student", "Student")
                        .WithMany("Courses")
                        .HasForeignKey("StudentEmail")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("idCardApp.API.Models.Lector", b =>
                {
                    b.HasOne("idCardApp.API.Models.Course", "Course")
                        .WithOne("Lector")
                        .HasForeignKey("idCardApp.API.Models.Lector", "CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("idCardApp.API.Models.PEDate", b =>
                {
                    b.HasOne("idCardApp.API.Models.Course", "Course")
                        .WithMany("PeDates")
                        .HasForeignKey("CourseId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
