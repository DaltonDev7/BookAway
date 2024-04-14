

using BookAway.Application.Dtos;
using BookAway.Application.Dtos.EstadoReserva;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class EstadoReservasServices : IEstadoReservaServices
    {


        private readonly IUnityOfWork _unityOfWork;

        public EstadoReservasServices(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<ApiResponseDto<string>> Create(AddEstadoReservaDto dto)
        {

            var newEstado = new EstadoReserva()
            {
                Descripcion = dto.Descripcion
            };

            await _unityOfWork.EstadoReservaRepository.Insert(newEstado);
            await _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public  async Task<List<EstadoReserva>> GetAll()
        {
            return (await _unityOfWork.EstadoReservaRepository.GetAll()).ToList();
        }

        public Task<EstadoReserva> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponseDto<string>> Update(UpdateEstadoReservaDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
