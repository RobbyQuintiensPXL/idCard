﻿using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApp.API.Repositories
{
    public interface ILectorRepository
    {
        Task<IEnumerable<Lector>> ListAsync();

        Lector GetLector(int id);
    }
}