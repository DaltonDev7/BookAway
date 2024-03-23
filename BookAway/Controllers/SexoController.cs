using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Sexo;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexoController : ControllerBase
    {
        private readonly ISexoServices _services;

        public SexoController(ISexoServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddSexoDto data)
        {
            return Ok(await _services.Create(data));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _services.GetAll();
            return Ok(new ApiResponseDto<List<Sexo>>(response));
        }


    }
}
