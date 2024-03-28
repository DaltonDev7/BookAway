using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Hotel;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IHotelServices
    {
        ApiResponseDto<string> CreateHotel(AddUpdateHotelDto data);
        Task<SignInResponseHotelDto> SignIn(SignInHotelDto dto);
        Task<List<HotelListDto>> GetAll();
    }
}
