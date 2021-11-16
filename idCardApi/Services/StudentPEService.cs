using idCardApi.Models;
using idCardApi.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public class StudentPEService: IStudentPEService
    {
        private IStudentPERepository _studentPERepository;

        public StudentPEService(IStudentPERepository studentPERepository)
        {
            _studentPERepository = studentPERepository;
        }

        public StudentPE GetPe(int id)
        {
            return _studentPERepository.GetPE(id);
        }

        public void UpdateStudentPEStatus(int id, string email)
        {
            _studentPERepository.UpdateStudentStatus(id, email);
        }
    }
}
