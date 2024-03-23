using Azure;
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Ciudad;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly ICiudadServices _services;

        public CiudadController(ICiudadServices services)
        {
            _services = services;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddCiudadDto data)
        {
            return Ok(await _services.Create(data));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var response = await _services.GetAll();
            return Ok(new ApiResponseDto<List<Ciudad>>(response));
        }
    }
}
