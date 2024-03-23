using BookAway.Application.Dtos;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IHotelServices _hotelServices;

        public HotelController(IHotelServices hotelServices)
        {
            _hotelServices = hotelServices;
        }

        [HttpPost]
        public IActionResult Create(AddUpdateHotelDto data)
        {
            return Ok(_hotelServices.CreateHotel(data));
        }

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var response = await _hotelServices.GetAll();
            return Ok(new ApiResponseDto<List<Hotel>>(response));
        }

    }
}
