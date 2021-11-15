using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Models
{
    public class StudentCourse
    {
        private string _studentEmail;
        private int _courseId;
        private Student _student;
        private Course _course;

        public string StudentEmail { get => _studentEmail; set => _studentEmail = value; }
        public int CourseId { get => _courseId; set => _courseId = value; }
        public Student Student { get => _student; set => _student = value; }
        public Course Course { get => _course; set => _course = value; }
    }
}
