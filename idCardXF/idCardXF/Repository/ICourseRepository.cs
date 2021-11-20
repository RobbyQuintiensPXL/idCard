using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Repository
{
    public interface ICourseRepository
    {
        Task<List<Lector>> GetAllCourses(string email);
    }
}
