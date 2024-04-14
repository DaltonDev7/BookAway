

using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;

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
            IBaseRepository<EstadoReserva> estadoReservaRepository,
            IHabitacionRepository habitacionRepository,
            IReservaRepository reservaRepository,
            IHotelRepository hotelRepository
            )
        {
            _context = context;
            SexoRepository = sexoRepository;
            PaisRepository = paisRepository;
            CiudadRepository = ciudadRepository;
            ProvinciaRepository = provinciaRepository;
            HotelRepository = hotelRepository;
            ReservaRepository = reservaRepository;
            EstadoReservaRepository = estadoReservaRepository;
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

        public IBaseRepository<EstadoReserva> EstadoReservaRepository { get; }

        public IReservaRepository ReservaRepository { get; }

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
