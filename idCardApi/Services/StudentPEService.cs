using idCardApi.Models;
using idCardApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public class StudentPEService
    {
        private IStudentPERepository _studentPERepository;

        public StudentPEService(IStudentPERepository studentPERepository)
        {
            _studentPERepository = studentPERepository;
        }

        public void UpdateStudent(StudentPE studentPE)
        {
            _studentPERepository.UpdateAttented(studentPE);
        }
    }
}
