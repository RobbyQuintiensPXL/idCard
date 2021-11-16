using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Repositories
{
    public interface ICourseRepository
    {
        Task<IEnumerable<Course>> ListAsync();

        Course GetCourse(int id);

        Task<IEnumerable<Course>> ListPEDates(int id);

    }
}
