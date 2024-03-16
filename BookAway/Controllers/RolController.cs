using BookAway.Application.Dtos;
using BookAway.Application.Interfaces;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class RolController : ControllerBase
    {
        private readonly IRoleServices _roleServices;

        public RolController(IRoleServices roleServices)
        {
            _roleServices = roleServices;
        }

        [HttpPost]
        [Route("Create")]
        public async Task<IActionResult> Create(CreateRolDto createRolDto)
        {
            await _roleServices.CreateRol(createRolDto);
            return Ok(new ApiResponseDto<string>("Rol creado correctamente."));
        }

        [HttpGet]
        [Route("GetAll")]
        public async Task<IActionResult> GetAll()
        {
            var response = await _roleServices.GetRoles();
            return Ok(new ApiResponseDto<List<Rol>>(response));
        }
    }
}
