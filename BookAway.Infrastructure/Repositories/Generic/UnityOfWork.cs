

using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;

namespace BookAway.Infrastructure.Repositories.Generic
{
    public class UnityOfWork : IUnityOfWork
    {
        public readonly BookAwayContext _context;

        public UnityOfWork(
            BookAwayContext context,
            IBaseRepository<Sexo> sexoRepository,
            IBaseRepository<Pais> paisRepository,
            IBaseRepository<TipoHabitacion> tipoHabitacionRepository,
            IBaseRepository<Ciudad> ciudadRepository,
            IBaseRepository<Provincia> provinciaRepository,
            IHabitacionRepository habitacionRepository,
            IHotelRepository hotelRepository
            )
        {
            _context = context;
            SexoRepository = sexoRepository;
            PaisRepository = paisRepository;
            CiudadRepository = ciudadRepository;
            ProvinciaRepository = provinciaRepository;
            HotelRepository = hotelRepository;
            TipoHabitacionRepository = tipoHabitacionRepository;
            HabitacionRepository = habitacionRepository;
        }

        public IBaseRepository<Sexo> SexoRepository { get; }

        public IBaseRepository<Pais> PaisRepository { get; }

        public IBaseRepository<Ciudad> CiudadRepository { get; }

        public IBaseRepository<Provincia> ProvinciaRepository { get; }

        public IHotelRepository HotelRepository { get; }

        public IBaseRepository<TipoHabitacion> TipoHabitacionRepository { get; }

        public IHabitacionRepository HabitacionRepository { get; }

        public async Task Commit()
        {
            await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            if (_context != null)
            {
                _context.Dispose();
                GC.SuppressFinalize(this);
            }
        }
    }
}
