using idCardApi.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public interface IStudentPERepository
    {
        void UpdateAttented(StudentPE studentPE);
    }
}
