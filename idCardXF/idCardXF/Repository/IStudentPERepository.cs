using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Repository
{
    public interface IStudentPERepository
    {
        Task<IEnumerable<StudentPE>> GetAllStudents(int peId);

        Task ScanStudent(int id, string email, StudentPE studentPE);

        Task<StudentPE> GetStudentByIdAndEmail(int id, string email);

    }
}
