using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public interface ICourseService
    {
        Task<IEnumerable<Course>> ListAsync();

        Course GetCourse(int id);

        Task<IEnumerable<Course>> ListPEDatesAsync(int id);

    }
}
