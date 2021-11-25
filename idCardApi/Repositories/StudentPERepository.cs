using idCardApi.Models;
using idCardApp.API.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public class StudentPERepository: BaseRepository, IStudentPERepository
    {
        public StudentPERepository(idCardContext context): base(context)
        {

        }

        public async Task<IEnumerable<StudentPE>> GetStudents(int id)
        {
            return await _context.StudentPEs.Include(s => s.Student).Where(p => p.PeId == id).ToListAsync();
        }

        public void UpdateStudentStatus(int id, string email)
        {
            StudentPE foundStudent = _context.StudentPEs.Where(s => s.PeId == id).FirstOrDefault(s => String.Equals(s.StudentEmail, email));
            foundStudent.Attented = true;
            _context.SaveChanges();
        }
    }
}
