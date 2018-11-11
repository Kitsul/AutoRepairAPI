using AutoMapper;
using AutoRepair.Models;
using AutoRepair.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AutoRepair.Controllers
{
    [Route("api/appoimtment")]
    [ApiController]
    public class AppoimtmentController : Controller
    {
        private IAppoimtmentsRepository _appoimtmentRepository;
        private readonly IMapper _mapper;
        public AppoimtmentController(IAppoimtmentsRepository appoimtmentRepository, IMapper mapper)
        {
            _appoimtmentRepository = appoimtmentRepository ?? throw new ArgumentNullException(nameof(appoimtmentRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }
        [HttpPost]
        public async Task<IActionResult> CreateAppoimtment([FromBody] Appoimtment appoimtment)
        { 
            var t = DateTime.Parse(appoimtment.StartDate);
            var appoimtmentEntity = _mapper.Map<Entities.Appoimtment>(appoimtment);
            _appoimtmentRepository.AddAppoimtment(appoimtmentEntity);

            await _appoimtmentRepository.SaveChangesAsync();
            return Ok();
        }
       
    }
}
