using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface ITokenServices
    {
        Task<string> GenerateToken(Usuario usuario);
        Task<string> GenerateTokenHotel(Hotel hotel);
    }
}
