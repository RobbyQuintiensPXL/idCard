using idCardApi.Models;
using idCardApp.API.Models;
using idCardApp.API.Repositories;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Data
{
    public class idCardContext : DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Lector> Lectors { get; set; }
        public DbSet<PEDate> PEDates { get; set; }
        public DbSet<Student> Students { get; set; }
        public DbSet<StudentCourse> StudentCourses { get; set; }
        public DbSet<StudentPE> StudentPEs { get; set; }


        public idCardContext(DbContextOptions<idCardContext> options) : base(options) { }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //PK

            modelBuilder.Entity<Student>().HasIndex(student => student.Email).IsUnique();
            modelBuilder.Entity<Student>().HasKey(student => student.Email);

            modelBuilder.Entity<Lector>().HasIndex(Lector => Lector.Email).IsUnique();
            modelBuilder.Entity<Lector>().HasKey(Lector => Lector.Email);

            modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentEmail, sc.CourseId });
            modelBuilder.Entity<StudentCourse>().HasOne(s => s.Student).WithMany(c => c.Courses).HasForeignKey(p => p.StudentEmail);
            modelBuilder.Entity<StudentCourse>().HasOne(c => c.Course).WithMany(s => s.Students).HasForeignKey(p => p.CourseId);

            modelBuilder.Entity<Course>().HasOne(l => l.Lector).WithOne(c => c.Course).HasForeignKey<Lector>(c => c.CourseId);

            modelBuilder.Entity<PEDate>().HasOne(c => c.Course).WithMany(p => p.PeDates).HasForeignKey(c => c.CourseId);

            modelBuilder.Entity<StudentPE>().HasKey(sp => new { sp.StudentEmail, sp.PeId });
            modelBuilder.Entity<StudentPE>().HasOne(s => s.Student).WithMany(s => s.PeDates).HasForeignKey(p => p.StudentEmail);
            modelBuilder.Entity<StudentPE>().HasOne(s => s.PeDate).WithMany(s => s.AllStudents).HasForeignKey(p => p.PeId);



            //Seed Data

            var students = new[]
            {
                new Student{Id = 1, Name = "Metdebroek", Firstname = "Jaak", Email = "jaak.metdebroek@student.pxl.be", Role = Role.Student},
                new Student{Id = 2, Name = "Indebroek", Firstname = "Jos", Email = "jos.indebroek@student.pxl.be", Role = Role.Student},
                new Student{Id = 3, Name = "Vandebroek", Firstname = "Jef", Email = "jef.vandebroek@student.pxl.be", Role = Role.Student},
                new Student{Id = 4, Name = "Uitdebroek", Firstname = "Jakie", Email = "jakie.Uitdebroek@student.pxl.be", Role = Role.Student},
                new Student{Id = 5, Name = "Zonderbroek", Firstname = "John", Email = "john.zonderbroek@student.pxl.be", Role = Role.Student}
            };

            var courses = new[]
            {
                new Course{Id = 1, Name = ".Net Expert"},
                new Course{Id = 2, Name = "Java Expert"}
            };

            var lectors = new[]
            {
                new Lector{Id = 1, Firstname = "Kris", Name = "Hermans", Email = "kris.hermans@pxl.be", CourseId = 1, Role = Role.Lector},
                new Lector{Id = 2, Firstname = "Tom", Name = "Schuyten", Email = "tom.schuyten@pxl.be", CourseId = 2, Role = Role.Lector},
            };

            var peDates = new[]
            {
                new PEDate{Id = 1, CourseId = 1, Type = PEType.PE, Date = new DateTime(2021, 11, 14)},
                new PEDate{Id = 2, CourseId = 1, Type = PEType.Exam, Date = new DateTime(2021, 11, 17)},
                new PEDate{Id = 3, CourseId = 2, Type = PEType.Exam, Date = new DateTime(2021, 11, 19)},
                new PEDate{Id = 4, CourseId = 1, Type = PEType.PE, Date = new DateTime(2021, 11, 21)},
            };

            modelBuilder.Entity<Student>().HasData(students[0], students[1], students[2], students[3], students[4]);
            modelBuilder.Entity<Course>().HasData(courses[0], courses[1]);
            modelBuilder.Entity<Lector>().HasData(lectors[0], lectors[1]);
            modelBuilder.Entity<StudentCourse>().HasData(
                new StudentCourse
                {
                    StudentEmail = students[0].Email,
                    CourseId = courses[0].Id
                },
                new StudentCourse
                {
                    StudentEmail = students[0].Email,
                    CourseId = courses[1].Id
                },
                new StudentCourse
                {
                    StudentEmail = students[1].Email,
                    CourseId = courses[0].Id
                },
                new StudentCourse
                {
                    StudentEmail = students[1].Email,
                    CourseId = courses[1].Id
                },
                new StudentCourse
                {
                    StudentEmail = students[2].Email,
                    CourseId = courses[0].Id
                },
                new StudentCourse
                {
                    StudentEmail = students[2].Email,
                    CourseId = courses[1].Id
                },
                new StudentCourse
                {
                    StudentEmail = students[3].Email,
                    CourseId = courses[0].Id
                },
                new StudentCourse
                {
                    StudentEmail = students[3].Email,
                    CourseId = courses[1].Id
                }, new StudentCourse
                {
                    StudentEmail = students[4].Email,
                    CourseId = courses[0].Id
                }, new StudentCourse
                {
                    StudentEmail = students[4].Email,
                    CourseId = courses[1].Id
                }
                );
            modelBuilder.Entity<PEDate>().HasData(peDates[0], peDates[1], peDates[2], peDates[3]);

            modelBuilder.Entity<StudentPE>().HasData(
                new StudentPE
                {
                    StudentEmail = students[0].Email,
                    PeId = 1,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[1].Email,
                    PeId = 1,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[2].Email,
                    PeId = 1,
                    Attented = false
                }, new StudentPE
                {
                    StudentEmail = students[3].Email,
                    PeId = 1,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[4].Email,
                    PeId = 1,
                    Attented = false
                }, 
                new StudentPE
                {
                    StudentEmail = students[0].Email,
                    PeId = 2,
                    Attented = false
                }, new StudentPE
                {
                    StudentEmail = students[1].Email,
                    PeId = 2,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[2].Email,
                    PeId = 2,
                    Attented = false
                }, new StudentPE
                {
                    StudentEmail = students[3].Email,
                    PeId = 2,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[4].Email,
                    PeId = 2,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[0].Email,
                    PeId = 3,
                    Attented = false
                }, new StudentPE
                {
                    StudentEmail = students[1].Email,
                    PeId = 3,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[2].Email,
                    PeId = 3,
                    Attented = false
                }, new StudentPE
                {
                    StudentEmail = students[3].Email,
                    PeId = 3,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[4].Email,
                    PeId = 3,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[0].Email,
                    PeId = 4,
                    Attented = false
                }, new StudentPE
                {
                    StudentEmail = students[1].Email,
                    PeId = 4,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[2].Email,
                    PeId = 4,
                    Attented = false
                }, new StudentPE
                {
                    StudentEmail = students[3].Email,
                    PeId = 4,
                    Attented = false
                },
                new StudentPE
                {
                    StudentEmail = students[4].Email,
                    PeId = 4,
                    Attented = false
                }
                );

            //Console.WriteLine(studentRole.Description);


        }


    }
}
