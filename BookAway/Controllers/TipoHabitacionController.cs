using BookAway.Application.Dtos;
using BookAway.Application.Dtos.TipoHabitacion;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoHabitacionController : ControllerBase
    {
        private readonly ITipoHabitacionServices _tipoHabitacionServices;

        public TipoHabitacionController(ITipoHabitacionServices tipoHabitacionServices)
        {
            _tipoHabitacionServices = tipoHabitacionServices;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddTipoHabitacionDto data)
        {
            return Ok(await _tipoHabitacionServices.Create(data));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _tipoHabitacionServices.GetAll();
            return Ok(new ApiResponseDto<List<TipoHabitacion>>(response));
        }

    }
}
