using AutoRepair.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Controllers
{
    [Route("api/appoimtment")]
    [ApiController]
    public class AppoimtmentController : Controller
    {
        private IAppoimtmentsRepository _appoimtmentRepository;
        public AppoimtmentController(IAppoimtmentsRepository appoimtmentRepository)
        {
            _appoimtmentRepository = appoimtmentRepository ?? throw new ArgumentNullException(nameof(appoimtmentRepository));
        }
        public async Task<IActionResult> CreateAppoimtment([FromBody] int id)
        {
            return Ok();
        }
    }
}
