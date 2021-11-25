using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Repository
{
    public interface IStudentRepository
    {
        Task<Student> GetStudent(string email);

        Task<IEnumerable<Student>> GetStudentsByPEId(int id);
    }
}
