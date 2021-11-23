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

        [HttpGet("{email}")]
        public async Task<IEnumerable<StudentCourse>> CoursesAsync(string email)
        {
            var courses = await _studentCourseService.ListAsyncCourses(email);
            return courses;
        }

        [HttpGet]
        public async Task<IEnumerable<StudentCourse>> ListAsync()
        {
            var studentCourses = await _studentCourseService.ListAsync();
            return studentCourses;
        }
    }
}
