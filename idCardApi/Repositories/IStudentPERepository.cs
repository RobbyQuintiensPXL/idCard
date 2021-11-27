using idCardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public interface IStudentPERepository
    {
        Task<IEnumerable<StudentPE>> GetStudents(int id);

        void UpdateStudentStatus(int id, string email, StudentPE studentPE);

        Task<StudentPE> GetStudentPEByIdAndEmail(int id, string email);
    }
}
