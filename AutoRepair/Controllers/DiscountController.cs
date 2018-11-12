using AutoRepair.Filters;
using AutoRepair.ModelsDTO;
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

        /// <summary>
        /// Get user's discounts by id
        /// </summary>
        /// <param name="email"></param>
        /// <returns></returns>

        [HttpGet]
        [DiscountsResultFilter]
        public async Task<IActionResult> GetDiscounts(string email)
        {
            List<DiscountDto> lists = new List<DiscountDto>();
            var user = await _userRepository.GetUserAsync(email);
            if(user == null)
            {
                return NotFound();
            }
            var discounts = await _discountRepository.GetDiscountAsync();
            var userDiscounts = discounts.Where(x => x.UserDiscount.All(v => v.UserId == user.Id)).ToList();
            if (userDiscounts == null)
            {
                return NotFound();
            }

            return Ok(userDiscounts);
        }
    }
}
