using idCardApi.Models;
using idCardApi.Repositories;
using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public class StudentCourseService : IStudentCourseService
    {
        private IStudentCourseRepository _studentCourseRepository;

        public StudentCourseService(IStudentCourseRepository studentCourseRepository)
        {
            _studentCourseRepository = studentCourseRepository;
        }
        public async Task<IEnumerable<Student>> ListAsyncStudents(int id)
        {
            return await _studentCourseRepository.GetStudents(id);
        }

        public async Task<IEnumerable<StudentCourse>> ListAsync()
        {
            return await _studentCourseRepository.ListAsync();
        }
    }
}
