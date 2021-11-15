using idCardApi.Repositories;
using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public class PEDateService : IPEDateService
    {
        private readonly IPEDateRepository _pEDateRepository;

        public PEDateService(IPEDateRepository pEDateRepository)
        {
            _pEDateRepository = pEDateRepository;
        }
        public async Task<IEnumerable<PEDate>> ListAsync()
        {
            return await _pEDateRepository.ListAsync();
        }
    }
}
