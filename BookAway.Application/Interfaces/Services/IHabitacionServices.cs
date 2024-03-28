

using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Habitacion;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IHabitacionServices : IService<Habitacion, AddHabitacionDto, UpdateHabitacionDto>
    {
        Task<List<ListHabitacionDto>> GetListHabitaciones();
    }
}
