
using BookAway.Application.Dtos.Pais;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IPaisServices: IService<Pais, AddPaisDto, UpdatePaisDto>
    {

    }
}
