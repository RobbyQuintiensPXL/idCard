using idCardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public interface IStudentPEService
    {
        StudentPE GetPe(int id);
        void UpdateStudentPEStatus(int id, string email);
    }
}
