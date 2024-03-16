

using BookAway.Application.Interfaces.Repositories;

namespace BookAway.Application.Interfaces.Generic
{
    public interface IUnityOfWork
    {
        ISexoRepository sexoRepository { get; }

        int Complete();
        void Dispose();
    }
}
