﻿using idCardApi.Services;
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
    public class PEDatesController : Controller
    {
        private readonly IPEDateService _pEDateService;

        public PEDatesController(IPEDateService pEDateService)
        {
            _pEDateService = pEDateService;
        }

        [HttpGet]
        public async Task<IEnumerable<PEDate>> GetAllAsync()
        {
            var peDates = await _pEDateService.ListAsync();
            return peDates;
        }
    }
}
