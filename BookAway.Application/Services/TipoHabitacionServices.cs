
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.TipoHabitacion;
using BookAway.Application.Interfaces.Common;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class TipoHabitacionServices : ITipoHabitacionServices
    {
        private readonly IUnityOfWork unityOfWork;

        public TipoHabitacionServices(IUnityOfWork unityOfWork)
        {
            this.unityOfWork = unityOfWork;
        }

        public async Task<ApiResponseDto<string>> Create(AddTipoHabitacionDto dto)
        {
            var tipoHabitacion = new TipoHabitacion
            {
                Descripcion = dto.Descripcion,
                Nombre = dto.Nombre
            };

            await unityOfWork.TipoHabitacionRepository.Insert(tipoHabitacion);
            await unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<TipoHabitacion>> GetAll()
        {
            return  (await unityOfWork.TipoHabitacionRepository.GetAll()).ToList();
        }

        public Task<TipoHabitacion> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponseDto<string>> Update(UpdateTipoHabitacionDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
