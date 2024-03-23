

using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Pais;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class PaisServices : IPaisServices
    {

        private readonly IUnityOfWork _unityOfWork;

        public PaisServices(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<ApiResponseDto<string>> Create(AddPaisDto dto)
        {
            var pais = new Pais()
            {
                Descripcion = dto.Descripcion
            };

            await _unityOfWork.PaisRepository.Insert(pais);
            await _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Pais>> GetAll()
        {
           return (await _unityOfWork.PaisRepository.GetAll()).ToList();
        }

        public Task<Pais> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponseDto<string>> Update(UpdatePaisDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
