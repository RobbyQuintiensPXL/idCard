﻿using idCardApi.Models;
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

        public async Task<StudentPE> GetStudentPEByIdAndEmail(int id, string email)
        {
            return await _studentPERepository.GetStudentPEByIdAndEmail(id, email);
        }

        public async Task<IEnumerable<StudentPE>> GetStudents(int id)
        {
            return await _studentPERepository.GetStudents(id);
        }

        public void UpdateStudentPEStatus(int id, string email, StudentPE studentPE)
        {
            _studentPERepository.UpdateStudentStatus(id, email, studentPE);
        }
    }
}
