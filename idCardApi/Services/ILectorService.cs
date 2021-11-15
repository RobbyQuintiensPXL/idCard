using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Services
{
    public interface ILectorService
    {
        Task<IEnumerable<Lector>> ListAsync();

        Lector GetLector(int id);
    }
}
