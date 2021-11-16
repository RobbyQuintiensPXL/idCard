using idCardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public interface IStudentPERepository
    {
        StudentPE GetPE(int id);

        void UpdateStudentStatus(int id, string email);
    }
}
