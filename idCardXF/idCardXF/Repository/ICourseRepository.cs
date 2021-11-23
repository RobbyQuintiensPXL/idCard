using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Repository
{
    public interface ICourseRepository
    {
        Task<IEnumerable<StudentCourse>> GetAllCourses(string email);
    }
}
