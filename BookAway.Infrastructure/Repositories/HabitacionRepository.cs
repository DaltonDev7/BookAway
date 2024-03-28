
using BookAway.Application.Dtos.Habitacion;
using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using BookAway.Infrastructure.Repositories.Generic;
using Microsoft.EntityFrameworkCore;

namespace BookAway.Infrastructure.Repositories
{
    public class HabitacionRepository : BaseRepository<Habitacion>, IHabitacionRepository
    {
        public HabitacionRepository(BookAwayContext dbContext) : base(dbContext)
        {
        }

        public async Task<List<ListHabitacionDto>> GetListHabitacion()
        {
            return await _dbSet.Select(x => new ListHabitacionDto
            {
                TipoHabitacion = x.TipoHabitacion.Descripcion,
                Capacidad = x.Capacidad,
                Hotel = x.Hotel.Nombre,
                Id = x.Id,
                Numero = x.Numero,
                Ocupado = x.Ocupado,
                PrecioNoche = x.PrecioNoche
            }).ToListAsync();
        }

    }
}
