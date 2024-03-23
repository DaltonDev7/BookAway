using BookAway.Application.Dtos;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IHotelServices
    {
        ApiResponseDto<string> CreateHotel(AddUpdateHotelDto data);

        Task<List<Hotel>> GetAll();
    }
}
