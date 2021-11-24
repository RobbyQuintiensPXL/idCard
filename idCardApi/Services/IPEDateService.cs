using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public interface IPEDateService
    {
        Task<IEnumerable<PEDate>> ListAsync();

        Task<IEnumerable<PEDate>> ListByCourseIdAsync(int courseID);

        Task<PEDate> GetPEDate(int id);
    }
}
