using idCardApi.Models;
using idCardApi.Services;
using idCardApp.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentCoursesController : Controller
    {
        private IStudentCourseService _studentCourseService;

        public StudentCoursesController(IStudentCourseService studentCourseService)
        {
            _studentCourseService = studentCourseService;
        }

        [HttpGet("{id}")]
        public async Task<IEnumerable<Student>> StudentsAsync(int id)
        {
            var students = await _studentCourseService.ListAsyncStudents(id);
            return students;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentCourse>> ListAsync()
        {
            var studentCourses = await _studentCourseService.ListAsync();
            return studentCourses;
        }
    }
}
