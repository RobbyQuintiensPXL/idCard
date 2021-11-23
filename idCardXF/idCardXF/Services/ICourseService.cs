using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public interface ICourseService
    {
        //Course GetCourse(int id);

        Task<IEnumerable<StudentCourse>> GetCourses(string email);
    }
}
