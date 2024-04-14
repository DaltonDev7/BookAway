using BookAway.Application.Dtos.Reserva;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IReservaServices : IService<Reserva, AddReservaDto, UpdateReservaDto>
    {

    }
}
