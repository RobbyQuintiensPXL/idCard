using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public interface IStudentService
    {
        Task<IEnumerable<Student>> ListAsync();

        Student GetStudent(int id);

        Task<Student> GetStudentByMail(string email);


    }
}
