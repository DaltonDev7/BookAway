

using BookAway.Application.Dtos.Habitacion;
using BookAway.Application.Interfaces.Generic;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Repositories
{
    public interface IHabitacionRepository : IBaseRepository<Habitacion>
    {
        Task<List<ListHabitacionDto>> GetListHabitacion();
    }
}
