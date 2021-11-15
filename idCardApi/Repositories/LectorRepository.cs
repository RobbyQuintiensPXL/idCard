using idCardApp.API.Data;
using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Repositories
{
    public class LectorRepository : ILectorRepository
    {
        private idCardContext _context;

        public LectorRepository(idCardContext context)
        {
            _context = context;
        }
        public Lector GetLector(string name)
        {
            return _context.Lectors.Find(name);
        }
    }
}
