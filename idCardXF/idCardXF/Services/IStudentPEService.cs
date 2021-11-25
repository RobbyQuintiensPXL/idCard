using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public interface IStudentPEService
    {
        Task<IEnumerable<StudentPE>> GetStudents(int peId);

        Task ScanStudent(StudentPE studentPE, string email);
    }
}
