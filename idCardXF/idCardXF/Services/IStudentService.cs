using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public interface IStudentService
    {
        Task<Student> GetStudent(string email);

        Task<IEnumerable<Student>> GetStudentByPEId(int id);
    }
}
