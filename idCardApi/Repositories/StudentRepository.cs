using idCardApp.API.Data;
using idCardApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public class StudentRepository : BaseRepository, IStudentRepository
    {
        public StudentRepository(idCardContext context): base(context)
        {

        }

        public Student GetStudent(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }

        public async Task<Student> GetStudentByMail(string email)
        {
            return await _context.Students.Include(c => c.Courses).Where(s => s.Email == email).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Student>> ListAsync()
        {
            return await _context.Students.ToListAsync();
        }

        public async Task<IEnumerable<Student>> ListCourses(string email)
        {
            return await _context.Students.Include(c => c.Courses).ThenInclude(x => x.CourseId).ToListAsync();
        }
    }
}
