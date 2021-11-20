using idCardXF.Models;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace idCardXF.Repository
{
    public interface ILectorRepository
    {
        Task<Lector> GetLector(string email);
    }
}

