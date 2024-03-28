using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Hotel;
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
        [Route("Register")]
        public IActionResult Create(AddUpdateHotelDto data)
        {
            return Ok(_hotelServices.CreateHotel(data));
        }


        [HttpPost]
        [Route("SignIn")]
        public async Task<IActionResult> SignIn(SignInHotelDto data)
        {
            var response = await _hotelServices.SignIn(data);
            return Ok(new ApiResponseDto<SignInResponseHotelDto>(response));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _hotelServices.GetAll();
            return Ok(new ApiResponseDto<List<HotelListDto>>(response));
        }

    }
}
