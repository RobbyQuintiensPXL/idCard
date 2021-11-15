using idCardApp.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Repositories
{
    public interface IPEDateRepository
    {
        Task<IEnumerable<PEDate>> ListAsync();
    }
}
