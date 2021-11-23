using idCardApi.Models;
using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public interface IStudentCourseService
    {
        Task<IEnumerable<StudentCourse>> ListAsyncCourses(string email);
        Task<IEnumerable<StudentCourse>> ListAsync();

    }
}
