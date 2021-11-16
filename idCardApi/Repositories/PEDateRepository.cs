using idCardApp.API.Data;
using idCardApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public class PEDateRepository : BaseRepository ,IPEDateRepository
    {
        public PEDateRepository(idCardContext context): base(context)
        {

        }

        public async Task<IEnumerable<PEDate>> GetByCourseId(int courseId)
        {
            return await _context.PEDates.Where(c => c.CourseId == courseId).ToListAsync();
        }

        public Task<PEDate> GetPEDate(int id)
        {
            return _context.PEDates.Include(s => s.AllStudents).FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<PEDate>> ListAsync()
        {
            return await _context.PEDates.ToListAsync();
        }
    }
}
