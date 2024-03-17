

using BookAway.Application.Interfaces.Repositories;

namespace BookAway.Application.Interfaces.Generic
{
    public interface IUnityOfWork
    {
        ISexoRepository sexoRepository { get; }
        IHotelRepository HotelRepository { get; }
        IPaisRepository PaisRepository { get; }
        ICiudadRepository CiudadRepository { get; }
        IProvinciaRepository ProvinciaRepository { get; }

        int Complete();
        void Dispose();
    }
}
