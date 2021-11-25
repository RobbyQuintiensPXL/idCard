﻿using idCardApi.Models;
using idCardApi.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentPEController : Controller
    {
        private readonly IStudentPEService _studentPEService;

        public StudentPEController(IStudentPEService studentPEService)
        {
            _studentPEService = studentPEService;
        }

        [HttpPut("{id}/{email}")]
        public ActionResult UpdateStudentStatus(int id, string email)
        {
            _studentPEService.UpdateStudentPEStatus(id, email);
            return Ok();
        }

        [HttpGet("pe/{id}")]
        public async Task<IEnumerable<StudentPE>> GetStudents(int id)
        {
            var students = await _studentPEService.GetStudents(id);
            return students;
        }
    }
}
