using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Provincia;
using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProvinciaController : ControllerBase
    {
        private readonly IUnityOfWork _unityOfWork;

        public ProvinciaController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        [HttpPost]
        public IActionResult Create(AddProvinciaDto data)
        {
            var provincia = new Provincia
            {
                Descripcion = data.Descripcion,
                IdPais = data.IdPais,
            };

            _unityOfWork.ProvinciaRepository.Add(provincia);
            _unityOfWork.Complete();

            return Ok(new ApiResponseDto<string>("Provincia creado correctamente"));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _unityOfWork.ProvinciaRepository.GetAll();
            return Ok(new ApiResponseDto<IEnumerable<Provincia>>(response));
        }



    }
}
