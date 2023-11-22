using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using WebAPI.DataTransferObject;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratoryController : ControllerBase
    {
        private readonly ILogger<LaboratoryController> _logger;
        private readonly ILaboratoryService service;


        public LaboratoryController(ILogger<LaboratoryController> logger, ILaboratoryService service)
        {
            this.service = service;
            _logger = logger;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLaboratory([FromBody] Laboratory laboratoryToCreate)
        {
            return this.Ok(await this.service.AddLaboratory(laboratoryToCreate));
        }

        [HttpGet(Name = "GetLaboratories")]
        public async Task<IActionResult> Get()
        {
            return this.Ok( await this.service.GetLaboratories());
        }
    }
}
