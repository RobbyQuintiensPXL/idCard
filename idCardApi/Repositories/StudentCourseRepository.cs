using idCardApi.Models;
using idCardApp.API.Data;
using idCardApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public class StudentCourseRepository : BaseRepository, IStudentCourseRepository
    {
        public StudentCourseRepository(idCardContext context): base(context)
        {

        }
        public async Task<IEnumerable<Student>> GetStudents(int id)
        {
            return await (Task<IEnumerable<Student>>)_context.StudentCourses.ToList().Where(c => c.CourseId == id);
        }

        public async Task<IEnumerable<StudentCourse>> ListAsync()
        {
            return await _context.StudentCourses.ToListAsync();
        }
    }
}
