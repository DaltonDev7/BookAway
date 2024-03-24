

using AutoMapper;
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Hotel;
using BookAway.Application.Exception;
using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Repositories;
using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Constants;
using BookAway.Domain.Entities;
using BookAway.Domain.Enums;
using Microsoft.AspNetCore.Identity;

namespace BookAway.Application.Services
{
    public class HotelServices : IHotelServices
    {
        private readonly IHotelRepository _hotelRepository;
        private readonly IUnityOfWork _unityOfWork;
        private readonly IMapper _mapper;
        private readonly ITokenServices _tokenServices;
        private readonly RoleManager<Rol> _roleManager;

        public HotelServices(
            RoleManager<Rol> roleManager, 
            ITokenServices tokenServices, 
            IHotelRepository hotelRepository, 
            IUnityOfWork unityOfWork, 
            IMapper mapper)
        {
            _hotelRepository = hotelRepository;
            _unityOfWork = unityOfWork;
            _mapper = mapper;
            _tokenServices = tokenServices;
            _roleManager = roleManager;
        }

        public ApiResponseDto<string> CreateHotel(AddUpdateHotelDto data)
        {
            var rncData = _hotelRepository.ValidateRNC(data.RNC);
            if (rncData) throw new ApiException("El rnc ya esta registrado");

            var emailData = _hotelRepository.ValidateEmail(data.Email);
            if (emailData) throw new ApiException("El email ya esta registrado");


            var newHotel = _mapper.Map<Hotel>(data);
            newHotel.IdRol = 2;
            newHotel.PassWord = BCrypt.Net.BCrypt.HashPassword(newHotel.PassWord);
            _hotelRepository.Insert(newHotel);
            _unityOfWork.Commit();

            return new ApiResponseDto<string>(ResponseApiEnum.ItemCreated);
        }

        public async Task<SignInResponseHotelDto> SignIn(SignInHotelDto dto)
        {
            var hotel = await _hotelRepository.Get(h => h.Email == dto.Email);
            if(hotel == null) throw new ApiException("Credenciales incorrectas");

            bool isValidPassword = BCrypt.Net.BCrypt.Verify(dto.PassWord, hotel.PassWord);

            if(!isValidPassword) throw new ApiException("Credenciales incorrectas");

            string token = await _tokenServices.GenerateTokenHotel(hotel);

            return new SignInResponseHotelDto()
            {
                Errors = null,
                Token = token,
                Hotel = new HotelResponseSignInDto()
                {
                    Descripcion = hotel.Descripcion,
                    Email = dto.Email,
                    Rol = RolesConstants.Hotel
                }
            };

        }

        public async Task<List<Hotel>> GetAll()
        {
            return (await _hotelRepository.GetAll()).ToList();
        }

       



    }
}
