

using AutoMapper;
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Habitacion;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;

namespace BookAway.Application.Services
{
    public class HabitacionServices : IHabitacionServices
    {
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public HabitacionServices(IUnityOfWork unityOfWork, IMapper mapper)
        {
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public async Task<ApiResponseDto<string>> Create(AddHabitacionDto dto)
        {
            var newHabitacion = _mapper.Map<Habitacion>(dto);

            await _unityOfWork.HabitacionRepository.Insert(newHabitacion);
            await _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public Task<ApiResponseDto<string>> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Habitacion>> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<Habitacion> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<List<ListHabitacionDto>> GetListHabitaciones()
        {
            return await _unityOfWork.HabitacionRepository.GetListHabitacion();
        }

        public Task<ApiResponseDto<string>> Update(UpdateHabitacionDto dto)
        {
            throw new NotImplementedException();
        }

    }
}
