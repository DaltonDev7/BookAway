﻿

using AutoMapper;
using BookAway.Application.Dtos;
using BookAway.Application.Exception;
using BookAway.Application.Interfaces;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;

namespace BookAway.Application.Services
{
    public class HotelServices : IHotelServices
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;

        public HotelServices(IHotelRepository hotelRepository, IUnityOfWork unityOfWork, IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _unityOfWork = unityOfWork;
            _mapper = mapper;
        }

        public ApiResponseDto<string> CreateHotel(AddUpdateHotelDto data)
        {
            var rncData = _hotelRepository.ValidateRNC(data.RNC);
            if (rncData) throw new ApiException("El rnc ya esta registrado");

            var emailData = _hotelRepository.ValidateEmail(data.Email);
            if (emailData) throw new ApiException("El email ya esta registrado");


            var newHotel = _mapper.Map<Hotel>(data);
            _hotelRepository.Add(newHotel);
            _unityOfWork.Complete();

            return new ApiResponseDto<string>("Hotel creado correctamente");
        }



    }
}