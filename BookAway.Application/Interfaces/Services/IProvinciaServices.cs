
using BookAway.Application.Dtos.Provincia;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IProvinciaServices : IService<Provincia, AddProvinciaDto, UpdateProvinciaDto>
    {

    }
}
