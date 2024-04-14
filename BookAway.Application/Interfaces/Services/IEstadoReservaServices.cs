

using BookAway.Application.Dtos.EstadoReserva;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IEstadoReservaServices : IService<EstadoReserva, AddEstadoReservaDto, UpdateEstadoReservaDto>
    {
     
    }
}
