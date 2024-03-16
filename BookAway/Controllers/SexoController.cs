
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Sexo;
using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SexoController : ControllerBase
    {
        private readonly IUnityOfWork _unityOfWork;

        public SexoController(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        [HttpPost]
        public IActionResult Create(AddSexoDto data)
        {
            var sexo = new Sexo
            {
                Descripcion = data.Descripcion,
                FechaCreacion = DateTime.Now,
            };

            _unityOfWork.sexoRepository.Add(sexo);
            _unityOfWork.Complete();

            return Ok(new ApiResponseDto<string>("Sexo creado correctamente"));
        }

        [HttpGet]
        public IActionResult Get()
        {
            var response =  _unityOfWork.sexoRepository.GetAll();
            return Ok(new ApiResponseDto<IEnumerable<Sexo>>(response));
        }


    }
}
