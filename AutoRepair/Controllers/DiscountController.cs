using AutoRepair.Filters;
using AutoRepair.Models;
using AutoRepair.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AutoRepair.Controllers
{
    [Route("api/discount")]
    [ApiController]
    public class DiscountController : Controller
    {
        private IDiscountRepository _discountRepository;
        private IUserRepository _userRepository;
        public DiscountController(IDiscountRepository discountRepository, IUserRepository userRepository)
        {
            _discountRepository = discountRepository ?? throw new ArgumentNullException(nameof(discountRepository));
            _userRepository = userRepository ?? throw new ArgumentNullException(nameof(userRepository));
        }

        [HttpGet]
        [DiscountsResultFilter]
        public async Task<IActionResult> GetDiscounts(string email)
        {
            List<Discount> lists = new List<Discount>();
            var user = await _userRepository.GetUserAsync("bill_gates@gmail.com");
            if(user == null)
            {
                return NotFound();
            }
            var discounts = await _discountRepository.GetDiscountAsync();

            var result = discounts.Join(user.UserDiscountServices,
                                        d => d.Id,
                                        uds => uds.DiscountId,
                                        (d, uds) => new Discount()
                                        {
                                            DiscountMessage = $"{ d.Count} {d.Description}"
                                        });

            return Ok(result);
        }
    }
}
