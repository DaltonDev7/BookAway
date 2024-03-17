using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Ciudad;
using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CiudadController : ControllerBase
    {
        private readonly IUnityOfWork _unityOfWork;

        public CiudadController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        [HttpPost]
        public IActionResult Create(AddCiudadDto data)
        {
            var ciudad = new Ciudad
            {
                Descripcion = data.Descripcion,
                IdProvincia = data.IdProvincia
            };

            _unityOfWork.CiudadRepository.Add(ciudad);
            _unityOfWork.Complete();

            return Ok(new ApiResponseDto<string>("Ciudad creado correctamente"));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _unityOfWork.CiudadRepository.GetAll();
            return Ok(new ApiResponseDto<IEnumerable<Ciudad>>(response));
        }
    }
}
