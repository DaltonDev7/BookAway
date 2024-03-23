
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Ciudad;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class CiudadServices : ICiudadServices
    {
        private readonly IUnityOfWork _unityOfWork;

        public CiudadServices(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<ApiResponseDto<string>> Create(AddCiudadDto dto)
        {
            var ciudad = new Ciudad
            {
                Descripcion = dto.Descripcion,
                IdProvincia = dto.IdProvincia
            };

            await _unityOfWork.CiudadRepository.Insert(ciudad);
            await _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Ciudad>> GetAll()
        {
            return (await _unityOfWork.CiudadRepository.GetAll()).ToList();
        }

        public Task<Ciudad> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponseDto<string>> Update(UpdateCiudadDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
