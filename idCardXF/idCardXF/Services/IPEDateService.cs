using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public interface IPEDateService
    {
        Task<IEnumerable<PEDate>> GetAllPEs(int courseId);
    }
}
