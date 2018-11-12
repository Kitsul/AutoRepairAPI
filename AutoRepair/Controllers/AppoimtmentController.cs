using AutoMapper;
using AutoRepair.Entities;
using AutoRepair.ModelsDTO;
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
        private IModelsCarRepository _modelsCarRepository;

        public AppoimtmentController(IAppoimtmentsRepository appoimtmentRepository,
            IMapper mapper,
            IModelsCarRepository modelsCarRepository)
        {
            _appoimtmentRepository = appoimtmentRepository ?? throw new ArgumentNullException(nameof(appoimtmentRepository));
            _modelsCarRepository = modelsCarRepository ?? throw new ArgumentNullException(nameof(modelsCarRepository));
        }

        /// <summary>
        /// Save appoimtment
        /// </summary>
        /// <param name="appoimtment"></param>
        /// <returns></returns>

        [HttpPost]
        public async Task<IActionResult> CreateAppoimtment([FromBody] AppoimtmentDto appoimtment)
        {
            try
            {
                var car = await _modelsCarRepository.GetModelCarAsync(appoimtment.Car.CarModel);
                var appoimtmentEntity = new Appoimtment()
                {
                    StartDate = appoimtment.StartDate,
                    EndDate = appoimtment.EndDate,
                    Message = appoimtment.Message,
                    Car = car,
                    User = new User()
                    {
                        FirstName = appoimtment.User.FirstName,
                        SecondName = appoimtment.User.SecondName,
                        Email = appoimtment.User.Email,
                        PhoneNumber = appoimtment.User.PhoneNumber
                    }

                };
                foreach (var serviceType in appoimtment.ServicesType)
                {
                    appoimtmentEntity.AppoimtmentServiceType.Add(new AppoimtmentServiceType()
                    {
                        ServiceType = serviceType,
                        Appoimtment = appoimtmentEntity,
                    });
                }
                _appoimtmentRepository.AddAppoimtment(appoimtmentEntity);
                await _appoimtmentRepository.SaveChangesAsync();
                return Ok();
            }
            catch(Exception ex)
            {
                return BadRequest();
            }
            
        }

    }
}
