using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Reserva;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ReservaController : ControllerBase
    {
        private readonly IReservaServices _services;

        public ReservaController(IReservaServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddReservaDto data)
        {
            return Ok(await _services.Create(data));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _services.GetAll();
            return Ok(new ApiResponseDto<List<Reserva>>(response));
        }

    }
}
