using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Reserva;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class ReservaServices : IReservaServices
    {
        private readonly IUnityOfWork _unityOfWork;

        public ReservaServices(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }


        public async Task<ApiResponseDto<string>> Create(AddReservaDto dto)
        {
            var reserva = new Reserva
            {
                Detalles = dto.Detalles,
                IdEstadoReserva = dto.IdEstadoReserva,
                IdHabitacion = dto.IdHabitacion,
                IdHotel = dto.IdHotel,
                IdUsuario = dto.IdUsuario,
                FechaSalida = dto.FechaSalida,
                FechaCreacion = dto.FechaEntrada
            };

            await _unityOfWork.ReservaRepository.Insert(reserva);
            await _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);

        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Reserva>> GetAll()
        {
            return (await _unityOfWork.ReservaRepository.GetAll()).ToList();
        }

        public Task<Reserva> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponseDto<string>> Update(UpdateReservaDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
