using AutoMapper;
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
        public IMapper Mapper { get; set; }
        public StudentCourseRepository(idCardContext context): base(context)
        {

        }
        public async Task<IEnumerable<StudentCourse>> GetCourses(string email)
        {
            return await _context.StudentCourses.Include(c => c.Course).Where(c => c.StudentEmail.Equals(email)).ToListAsync();
        }

        public async Task<IEnumerable<StudentCourse>> ListAsync()
        {
            return await _context.StudentCourses.ToListAsync();
        }

    }
}
