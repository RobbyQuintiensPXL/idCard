using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public class CourseService : ICourseService
    {
        private readonly HttpClient _httpClient;

        public CourseService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        //public Course GetCourse(int id)
        //{
        //    throw new NotImplementedException();
        //}

        //public List<IEnumerable<Course>> GetCourses()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
