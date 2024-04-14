using BookAway.Application.Dtos;
using BookAway.Application.Dtos.EstadoReserva;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadoReservaController : ControllerBase
    {
        private readonly IEstadoReservaServices _services;

        public EstadoReservaController(IEstadoReservaServices estadoServices)
        {
            _services = estadoServices;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddEstadoReservaDto data)
        {
            return Ok(await _services.Create(data));
        }

        [HttpGet]
       // [Authorize(Roles = "HOTEL,USUARIO,ADMINISTRADOR")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _services.GetAll();
            return Ok(new ApiResponseDto<List<EstadoReserva>>(response));
        }
    }
}
