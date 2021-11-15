using idCardApp.API.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public abstract class BaseRepository
    {
        protected readonly idCardContext _context;

        public BaseRepository(idCardContext context)
        {
            _context = context;
        }
    }
}
