using idCardXF.Models;
using idCardXF.Repository;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        //public Course GetCourse(int id)
        //{
        //    throw new NotImplementedException();
        //}

        public async Task<IEnumerable<StudentCourse>> GetCourses(string email)
        {
            return await _courseRepository.GetAllCourses(email);
        }
    }
}
