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
        public Lector GetLector(int id)
        {
            return _context.Lectors.FirstOrDefault(l => l.Id == id);
        }

        public async Task<IEnumerable<Lector>> ListAsync()
        {
            return await _context.Lectors.ToListAsync();
        }
    }
}
