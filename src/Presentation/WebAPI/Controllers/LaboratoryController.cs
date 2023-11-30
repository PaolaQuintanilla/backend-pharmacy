using Domain.Entities;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shared.Search.Entities;
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
        public async Task<IActionResult> CreateLaboratoryAsync([FromBody] Laboratory laboratoryToCreate)
        {
            return this.Ok(await this.service.AddLaboratoryAsync(laboratoryToCreate));
        }

        [HttpGet(Name = "GetLaboratories")]
        public async Task<IActionResult> GetLaboratoriesAsync(int current, int pageSize)
        {   
            return this.Ok( await this.service.GetLaboratoriesAsync(current, pageSize));
        }

        [HttpDelete]
        public async Task<ActionResult<Guid>> DeleteLaboratoryAsync([FromHeader] Guid id)
        {
            return this.Ok(await this.service.RemoveLaboratoryAsync(id));
        }
    }
}
