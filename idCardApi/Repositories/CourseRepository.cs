using idCardApi.Repositories;
using idCardApp.API.Data;
using idCardApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Repositories
{
    public class CourseRepository : BaseRepository, ICourseRepository
    {

        public CourseRepository(idCardContext context) : base(context)
        {

        }

        public Course GetCourse(int id)
        {
            return _context.Courses.Include(l => l.Lector).Include(s => s.Students).FirstOrDefault(c => c.Id == id);
        }

        public async Task<IEnumerable<Course>> ListAsync()
        {
            return await _context.Courses.Include(l => l.Lector).ToListAsync();
        }

        public async Task<IEnumerable<Course>> ListPEDates(int id)
        {
            return await _context.Courses.Include(p => p.PeDates).Include(l => l.Lector).Where(c => c.Id == id).ToListAsync();
        }
    }
}
