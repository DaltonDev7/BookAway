
using BookAway.Application.Dtos;

namespace BookAway.Application.Interfaces
{
    public interface IHotelServices
    {
        ApiResponseDto<string> CreateHotel(AddUpdateHotelDto data);
    }
}
