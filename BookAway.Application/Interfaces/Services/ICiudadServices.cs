
using BookAway.Application.Dtos.Ciudad;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface ICiudadServices : IService<Ciudad, AddCiudadDto, UpdateCiudadDto>
    {

    }
}
