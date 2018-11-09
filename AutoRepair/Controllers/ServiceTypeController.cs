using AutoRepair.Filters;
using AutoRepair.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Controllers
{
    [Route("api/servicesType")]
    [ApiController]
    public class ServiceTypeController : Controller
    {
        private IServicesTypeRepository _servicesTypeRepository;
        public ServiceTypeController(IServicesTypeRepository servicesTypeRepository)
        {
            _servicesTypeRepository = servicesTypeRepository ?? throw new ArgumentNullException(nameof(servicesTypeRepository)); 
        }

        [HttpGet]
        [ServicesTypeResultFilter]
        public async Task<IActionResult> GetServicesType()
        {
            var servicesType = await _servicesTypeRepository.GetServicesTypeAsync();
            return Ok(servicesType);
        }
    }
}
