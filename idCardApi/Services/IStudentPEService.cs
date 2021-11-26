using idCardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public interface IStudentPEService
    {
        Task<IEnumerable<StudentPE>> GetStudents(int id);
        void UpdateStudentPEStatus(int id, string email, StudentPE studentPE);

        StudentPE GetStudentPEByIdAndEmail(int id, string email);
    }
}
