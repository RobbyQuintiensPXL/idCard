using idCardApi.Repositories;
using idCardApp.API.Data;
using idCardApp.API.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Repositories
{
    public class LectorRepository : BaseRepository, ILectorRepository
    {
        public LectorRepository(idCardContext context) : base(context)
        {

        }
        public async Task<Lector> GetLector(string email)
        {
            return await _context.Lectors.Where(l => l.Email == email).FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<Lector>> ListAsync()
        {
            return await _context.Lectors.ToListAsync();
        }
    }
}
