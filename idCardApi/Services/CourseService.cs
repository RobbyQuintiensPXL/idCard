using idCardApp.API.Models;
using idCardApp.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public class CourseService : ICourseService
    {
        private ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }
        public Course GetCourse(int id)
        {
            return _courseRepository.GetCourse(id);
        }

        public async Task<IEnumerable<Course>> ListAsync()
        {
            return await _courseRepository.ListAsync();
        }
    }
}
