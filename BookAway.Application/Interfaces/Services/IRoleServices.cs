using BookAway.Application.Dtos;
using BookAway.Domain.Entities;

namespace BookAway.Application.Interfaces.Services
{
    public interface IRoleServices
    {
        Task CreateRol(CreateRolDto createRolDto);
        Task<List<Rol>> GetRoles();
    }
}
