

using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Sexo;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class SexoServices : ISexoServices
    {
        private readonly IUnityOfWork _unityOfWork;

        public SexoServices(IUnityOfWork unityOfWork)
        {
            _unityOfWork = unityOfWork;
        }

        public async Task<ApiResponseDto<string>> Create(AddSexoDto dto)
        {
            var sexo = new Sexo()
            {
                Descripcion = dto.Descripcion
            };

            await _unityOfWork.SexoRepository.Insert(sexo);
            await _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<Sexo>> GetAll()
        {
            return (await _unityOfWork.SexoRepository.GetAll()).ToList();
        }

        public Task<Sexo> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<ApiResponseDto<string>> Update(UpdateSexoDto dto)
        {
            throw new NotImplementedException();
        }
    }
}
