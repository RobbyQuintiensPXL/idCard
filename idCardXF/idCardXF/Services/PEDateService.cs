using idCardXF.Models;
using idCardXF.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public class PEDateService : IPEDateService
    {
        private readonly IPEDateRepository _pEDateRepository;

        public PEDateService(IPEDateRepository pEDateRepository)
        {
            _pEDateRepository = pEDateRepository;
        }

        public async Task<IEnumerable<PEDate>> GetAllPEs(int courseId)
        {
            return await _pEDateRepository.GetAllPEs(courseId);
        }
    }
}
