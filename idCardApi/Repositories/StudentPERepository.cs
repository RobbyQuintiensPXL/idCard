using idCardApi.Models;
using idCardApp.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public class StudentPERepository : BaseRepository, IStudentPERepository
    {
        public StudentPERepository(idCardContext context): base(context)
        {

        }
        public void UpdateAttented(StudentPE studentPE)
        {
            var student = _context.StudentPEs.Where(x => x.StudentEmail == studentPE.StudentEmail).FirstOrDefault();
            student.Attented = true;
        }
    }
}
