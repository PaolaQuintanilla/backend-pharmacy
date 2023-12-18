using Microsoft.AspNetCore.Mvc;
using Pharmacy.Application.Dtos.Laboratory.Request;
using Pharmacy.Application.Interfaces;

namespace Pharmacy.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LaboratoryController : ControllerBase
    {
        private readonly ILaboratoryApplication _laboratoryApplication;
        public LaboratoryController(ILaboratoryApplication laboratoryApplication)
        {
            this._laboratoryApplication = laboratoryApplication;
        }

        [HttpPost]
        public async Task<IActionResult> CreateLaboratoryAsync([FromBody] LaboratoryDto laboratoryToCreate)
        {
            return this.Ok(await this._laboratoryApplication.CreateLaboratory(laboratoryToCreate));
        }
    }
}
