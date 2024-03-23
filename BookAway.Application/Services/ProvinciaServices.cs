

using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Provincia;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class ProvinciaServices : IProvinciaServices
    {
        private readonly IUnityOfWork _unityOfWork;

        public ProvinciaServices(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<ApiResponseDto<string>> Create(AddProvinciaDto dto)
        {
            var provincia = new Provincia()
            {
                Descripcion = dto.Descripcion,
                IdPais = dto.IdPais,
            };

            await _unityOfWork.ProvinciaRepository.Insert(provincia);
            await _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Provincia>> GetAll()
        {
            return (await _unityOfWork.ProvinciaRepository.GetAll()).ToList();
         }

        public Task<Provincia> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponseDto<string>> Update(UpdateProvinciaDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
