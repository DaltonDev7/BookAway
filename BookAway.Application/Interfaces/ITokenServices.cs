

using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces
{
    public interface ITokenServices
    {
        Task<string> GenerateToken(Usuario usuario);
    }
}
