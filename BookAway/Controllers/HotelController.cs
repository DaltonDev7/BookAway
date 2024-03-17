using BookAway.Application.Dtos.Pais;
using BookAway.Application.Dtos;
using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAway.Infrastructure.Repositories.Generic;
using BookAway.Application.Interfaces;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HotelController : ControllerBase
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IHotelServices _hotelServices;

        public HotelController(IUnityOfWork unityOfWork, IHotelServices hotelServices)
        {
            _unityOfWork = unityOfWork;
            _hotelServices = hotelServices;
        }

        [HttpPost]
        public IActionResult Create(AddUpdateHotelDto data)
        {
            return Ok(_hotelServices.CreateHotel(data));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _unityOfWork.PaisRepository.GetAll();
            return Ok(new ApiResponseDto<IEnumerable<Pais>>(response));
        }

    }
}
