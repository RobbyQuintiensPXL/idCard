using idCardXF.Models;
using idCardXF.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    class StudentPEService : IStudentPEService
    {
        private IStudentPERepository _studentPERepository;

        public StudentPEService(IStudentPERepository studentPERepository)
        {
            _studentPERepository = studentPERepository;
        }

        public async Task<StudentPE> GetStudentByIdAndEmail(int id, string email)
        {
            return await _studentPERepository.GetStudentByIdAndEmail(id, email);
        }

        public async Task<IEnumerable<StudentPE>> GetStudents(int peId)
        {
            return await _studentPERepository.GetAllStudents(peId);
        }

        public async Task ScanStudent(int id, string email, StudentPE studentPE)
        {
            await _studentPERepository.ScanStudent(id, email, studentPE);
        }
    }
}
