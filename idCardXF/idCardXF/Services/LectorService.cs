using idCardXF.Models;
using idCardXF.Repository;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Services
{
    public class LectorService : ILectorService
    {
        private ILectorRepository _lectorRepository;

        public LectorService(ILectorRepository lectorRepository)
        {
            _lectorRepository = lectorRepository;
        }

        public async Task<Lector> GetLector(string email)
        {
            return await _lectorRepository.GetLector(email);
        }
    }
}
