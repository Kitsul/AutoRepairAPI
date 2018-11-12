using AutoRepair.Filters;
using AutoRepair.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace AutoRepair.Controllers
{
    [Route("api/modelCar")]
    [ApiController]
    public class ModelCarController : Controller
    {
        private IModelsCarRepository _modelsCarRepository;
        public ModelCarController(IModelsCarRepository modelsCarRepository)
        {
            _modelsCarRepository = modelsCarRepository ?? throw new ArgumentNullException(nameof(modelsCarRepository));
        }

        [HttpGet]
        [ModelsCarResultFilter]
        public async Task<IActionResult> GetModelsCar()
        {
            var modelsCar = await _modelsCarRepository.GetModelsCarAsync();
            return Ok(modelsCar);
        }
    }
}
