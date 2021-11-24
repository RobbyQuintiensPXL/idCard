using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Repository
{
    public interface IPEDateRepository
    {
        Task<IEnumerable<PEDate>> GetAllPEs(int courseId);
    }
}
