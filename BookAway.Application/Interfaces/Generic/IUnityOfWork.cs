

using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Generic
{
    public interface IUnityOfWork : IDisposable
    {
        IBaseRepository<Sexo> SexoRepository { get; }
        IBaseRepository<Pais> PaisRepository { get; }
        IBaseRepository<Ciudad> CiudadRepository { get; }
        IBaseRepository<Provincia> ProvinciaRepository { get; }
        IHotelRepository HotelRepository { get; }

        Task Commit();

    }
}
