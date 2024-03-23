using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Pais;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly IPaisServices _paisServices;

        public PaisController(IPaisServices paisServices)
        {
            _paisServices = paisServices;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddPaisDto data)
        {
            return Ok(await _paisServices.Create(data));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var response = await _paisServices.GetAll();
           return Ok(new ApiResponseDto<List<Pais>>(response));
        }

    }
}
