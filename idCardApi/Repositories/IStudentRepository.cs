using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public interface IStudentRepository
    {
        Task<IEnumerable<Student>> ListAsync();

        Student GetStudent(int id);

        Task<Student> GetStudentByMail(string email);

        Task<IEnumerable<Student>> ListCourses(string email);

        Task<IEnumerable<Student>> GetStudentsByPEId(int id);
    }
}
