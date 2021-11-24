using AutoMapper;
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
    public class CoursesController : Controller
    {
        private readonly ICourseService _courseService;

        public CoursesController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public async Task<IEnumerable<Course>> GetAllAsync()
        {
            var courses = await _courseService.ListAsync();
            return courses;
        }

        [HttpGet("{id}")]
        public Course GetCourse(int id)
        {
            return _courseService.GetCourse(id);
        }

        [HttpGet("{id}/pe")]
        public async Task<IEnumerable<Course>> GetPEDatesAsync(int id)
        {
            return await _courseService.ListPEDatesAsync(id);
        }

        //[HttpGet("{courseId}/pe/{peId}")]
        //public PEDate GetPEDateByCourseIdAndId(int courseId, int peId)
        //{
        //    return _courseService.GetPEDateByCourseIdAndId(courseId, peId);
        //}
    }
}
