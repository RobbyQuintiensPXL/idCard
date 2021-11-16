using idCardApi.Models;
using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public interface IStudentCourseRepository
    {
        Task<IEnumerable<StudentCourse>> ListAsync();

        Task<IEnumerable<Student>> GetStudents(int id);
    }
}
