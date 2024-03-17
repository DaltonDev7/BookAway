

using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Repositories
{
    public interface IHotelRepository : IBaseRepository<Hotel>
    {
        bool ValidateRNC(string rnc);
        bool ValidateEmail(string email);
    }
}
