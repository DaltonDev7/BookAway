using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Habitacion;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HabitacionController : ControllerBase
    {
        private readonly IHabitacionServices _services;

        public HabitacionController(IHabitacionServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddHabitacionDto data)
        {
            return Ok(await _services.Create(data));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _services.GetListHabitaciones();
            return Ok(new ApiResponseDto<List<ListHabitacionDto>>(response));
        }



    }
}
