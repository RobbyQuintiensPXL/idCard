using idCardApi.Services;
using idCardApp.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace idCardApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LectorsController : Controller
    {
        private readonly ILectorService _lectorService;

        public LectorsController(ILectorService lectorService)
        {
            _lectorService = lectorService;
        }

        [HttpGet]
        public async Task<IEnumerable<Lector>> GetAllAsync()
        {
            var lectors = await _lectorService.ListAsync();
            return lectors;
        }

        [HttpGet("{id}")]
        public Lector GetLector(int id)
        {
            return _lectorService.GetLector(id);
        }
    }
}
