

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
        }

        public ISexoRepository sexoRepository { get; }

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
