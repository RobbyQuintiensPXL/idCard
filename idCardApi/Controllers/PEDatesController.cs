using idCardApi.Models;
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
    public class PEDatesController : Controller
    {
        private readonly IPEDateService _pEDateService;
        private readonly StudentPEService _studentPEService;

        public PEDatesController(IPEDateService pEDateService, StudentPEService studentPEService)
        {
            _pEDateService = pEDateService;
            _studentPEService = studentPEService;
        }

        [HttpGet]
        public async Task<IEnumerable<PEDate>> GetAllAsync()
        {
            var peDates = await _pEDateService.ListAsync();
            return peDates;
        }

        //[HttpGet("{courseId}")]
        //public async Task<IEnumerable<PEDate>> GetByIdAsync(int courseId)
        //{
        //    var peDates = await _pEDateService.ListByCourseIdAsync(courseId);
        //    return peDates;
        //}

        [HttpGet("{id}")]
        public Task<PEDate> GetPEDate(int id)
        {
            return _pEDateService.GetPEDate(id);
        }

        [HttpPut("{{id}}")]
        public string PutStudentPE(StudentPE studentPE)
        {
            _studentPEService.UpdateStudent(studentPE);
            return "test";
        }


    }
}
