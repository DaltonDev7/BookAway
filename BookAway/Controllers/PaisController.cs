using BookAway.Application.Dtos.Sexo;
using BookAway.Application.Dtos;
using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using BookAway.Application.Dtos.Pais;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PaisController : ControllerBase
    {
        private readonly IUnityOfWork _unityOfWork;

        public PaisController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        [HttpPost]
        public IActionResult Create(AddPaisDto data)
        {
            var pais = new Pais
            {
                Descripcion = data.Descripcion,
            };

            _unityOfWork.PaisRepository.Add(pais);
            _unityOfWork.Complete();

            return Ok(new ApiResponseDto<string>("Pais creado correctamente"));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response = _unityOfWork.PaisRepository.GetAll();
            return Ok(new ApiResponseDto<IEnumerable<Pais>>(response));
        }

    }
}
