using idCardApi.Services;
using idCardApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : Controller
    {

        private readonly IStudentService _studentService;

        public StudentsController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public async Task<IEnumerable<Student>> GetAllAsync()
        {
            var students = await _studentService.ListAsync();
            return students;
        }

        [HttpGet("{email}")]
        public Student GetStudent(string email)
        {
            return _studentService.GetStudentByMail(email);
        }
    }
}
