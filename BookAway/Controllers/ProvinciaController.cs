using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Provincia;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
     
        private readonly IProvinciaServices _provinciaServices;

        public ProvinciaController(IProvinciaServices provinciaServices)
        {
            _provinciaServices = provinciaServices;
        }

        [HttpPost]
        public async Task<IActionResult> Create(AddProvinciaDto data)
        {
            return Ok(await _provinciaServices.Create(data));
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
           var response = await _provinciaServices.GetAll();
           return Ok(new ApiResponseDto<List<Provincia>>(response));
        }



    }
}
