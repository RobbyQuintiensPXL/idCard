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
    [Migration("20211116202308_idCardv5")]
    partial class idCardv5
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
                        },
                        new
                        {
                            StudentEmail = "jaak.metdebroek@student.pxl.be",
                            CourseId = 2
                        },
                        new
                        {
                            StudentEmail = "jos.indebroek@student.pxl.be",
                            CourseId = 1
                        },
                        new
                        {
                            StudentEmail = "jos.indebroek@student.pxl.be",
                            CourseId = 2
                        },
                        new
                        {
                            StudentEmail = "jef.vandebroek@student.pxl.be",
                            CourseId = 1
                        },
                        new
                        {
                            StudentEmail = "jef.vandebroek@student.pxl.be",
                            CourseId = 2
                        },
                        new
                        {
                            StudentEmail = "jakie.Uitdebroek@student.pxl.be",
                            CourseId = 1
                        },
                        new
                        {
                            StudentEmail = "jakie.Uitdebroek@student.pxl.be",
                            CourseId = 2
                        },
                        new
                        {
                            StudentEmail = "john.zonderbroek@student.pxl.be",
                            CourseId = 1
                        },
                        new
                        {
                            StudentEmail = "john.zonderbroek@student.pxl.be",
                            CourseId = 2
                        });
                });

            modelBuilder.Entity("idCardApi.Models.StudentPE", b =>
                {
                    b.Property<string>("StudentEmail")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("PeId")
                        .HasColumnType("int");

                    b.Property<bool>("Attented")
                        .HasColumnType("bit");

                    b.HasKey("StudentEmail", "PeId");

                    b.HasIndex("PeId");

                    b.ToTable("StudentPEs");

                    b.HasData(
                        new
                        {
                            StudentEmail = "jaak.metdebroek@student.pxl.be",
                            PeId = 1,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jos.indebroek@student.pxl.be",
                            PeId = 1,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jef.vandebroek@student.pxl.be",
                            PeId = 1,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jakie.Uitdebroek@student.pxl.be",
                            PeId = 1,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "john.zonderbroek@student.pxl.be",
                            PeId = 1,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jaak.metdebroek@student.pxl.be",
                            PeId = 2,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jos.indebroek@student.pxl.be",
                            PeId = 2,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jef.vandebroek@student.pxl.be",
                            PeId = 2,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jakie.Uitdebroek@student.pxl.be",
                            PeId = 2,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "john.zonderbroek@student.pxl.be",
                            PeId = 2,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jaak.metdebroek@student.pxl.be",
                            PeId = 3,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jos.indebroek@student.pxl.be",
                            PeId = 3,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jef.vandebroek@student.pxl.be",
                            PeId = 3,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jakie.Uitdebroek@student.pxl.be",
                            PeId = 3,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "john.zonderbroek@student.pxl.be",
                            PeId = 3,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jaak.metdebroek@student.pxl.be",
                            PeId = 4,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jos.indebroek@student.pxl.be",
                            PeId = 4,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jef.vandebroek@student.pxl.be",
                            PeId = 4,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "jakie.Uitdebroek@student.pxl.be",
                            PeId = 4,
                            Attented = false
                        },
                        new
                        {
                            StudentEmail = "john.zonderbroek@student.pxl.be",
                            PeId = 4,
                            Attented = false
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
                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(450)");

                    b.Property<int>("CourseId")
                        .HasColumnType("int");

                    b.Property<string>("Firstname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Id")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Role")
                        .HasColumnType("int");

                    b.HasKey("Email");

                    b.HasIndex("CourseId")
                        .IsUnique();

                    b.HasIndex("Email")
                        .IsUnique();

                    b.ToTable("Lectors");

                    b.HasData(
                        new
                        {
                            Email = "kris.hermans@pxl.be",
                            CourseId = 1,
                            Firstname = "Kris",
                            Id = 1,
                            Name = "Hermans",
                            Role = 1
                        },
                        new
                        {
                            Email = "tom.schuyten@pxl.be",
                            CourseId = 2,
                            Firstname = "Tom",
                            Id = 2,
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

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CourseId = 1,
                            Date = new DateTime(2021, 11, 14, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            CourseId = 1,
                            Date = new DateTime(2021, 11, 17, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 3,
                            CourseId = 2,
                            Date = new DateTime(2021, 11, 19, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 1
                        },
                        new
                        {
                            Id = 4,
                            CourseId = 1,
                            Date = new DateTime(2021, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            Type = 0
                        });
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
                        },
                        new
                        {
                            Email = "jakie.Uitdebroek@student.pxl.be",
                            Firstname = "Jakie",
                            Id = 4,
                            Name = "Uitdebroek",
                            Role = 0
                        },
                        new
                        {
                            Email = "john.zonderbroek@student.pxl.be",
                            Firstname = "John",
                            Id = 5,
                            Name = "Zonderbroek",
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

            modelBuilder.Entity("idCardApi.Models.StudentPE", b =>
                {
                    b.HasOne("idCardApp.API.Models.PEDate", "PeDate")
                        .WithMany("AllStudents")
                        .HasForeignKey("PeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("idCardApp.API.Models.Student", "Student")
                        .WithMany("PeDates")
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