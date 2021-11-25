using idCardApi.Repositories;
using idCardApp.API.Data;
using idCardApp.API.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public class StudentService : IStudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public Student GetStudent(int id)
        {
            return _studentRepository.GetStudent(id);
        }

        public async Task<Student> GetStudentByMail(string email)
        {
            return await _studentRepository.GetStudentByMail(email);
        }

        public async Task<IEnumerable<Student>> ListAsync()
        {
            return await _studentRepository.ListAsync();
        }

        public async Task<IEnumerable<Student>> GetStudentByPeId(int id)
        {
            return await _studentRepository.GetStudentsByPEId(id);
        }
    }
}
