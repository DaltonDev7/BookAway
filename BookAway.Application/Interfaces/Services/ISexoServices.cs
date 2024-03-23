
using BookAway.Application.Dtos.Sexo;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface ISexoServices : IService<Sexo, AddSexoDto, UpdateSexoDto>
    {
    }
}
