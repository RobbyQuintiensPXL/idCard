using idCardApp.API.Models;
using idCardApp.API.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public class LectorService : ILectorService
    {
        private readonly ILectorRepository _lectorRepository;

        public LectorService(ILectorRepository lectorRepository)
        {
            _lectorRepository = lectorRepository;
        }
        public async Task<Lector> GetLector(string email)
        {
            return await _lectorRepository.GetLector(email);
        }

        public async Task<IEnumerable<Lector>> ListAsync()
        {
            return await _lectorRepository.ListAsync();
        }
    }
}
