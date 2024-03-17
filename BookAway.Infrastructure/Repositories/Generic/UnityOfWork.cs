

using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Repositories;
using BookAway.Infrastructure.Context;

namespace BookAway.Infrastructure.Repositories.Generic
{
    public class UnityOfWork : IUnityOfWork, IDisposable
    {
        public readonly BookAwayContext _context;

        public UnityOfWork(BookAwayContext context)
        {
            _context = context;
            sexoRepository = new SexoRepository(_context);
            CiudadRepository = new CiudadRepository(_context);
            HotelRepository = new HotelRepository(_context);
            PaisRepository = new PaisRepository(_context);
            ProvinciaRepository = new ProvinciaRepository(_context);
        }

        public ISexoRepository sexoRepository { get; }

        public IHotelRepository HotelRepository { get; }

        public IPaisRepository PaisRepository { get; }

        public ICiudadRepository CiudadRepository { get; }

        public IProvinciaRepository ProvinciaRepository { get; }

        public int Complete()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
