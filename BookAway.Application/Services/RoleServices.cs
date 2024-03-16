
using BookAway.Application.Dtos;
using BookAway.Application.Exception;
using BookAway.Application.Interfaces;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;


namespace BookAway.Application.Services
{
    public class RoleServices : IRoleServices
    {
        private readonly RoleManager<Rol> _roleManager;

        public RoleServices(RoleManager<Rol> roleManager)
        {
            _roleManager = roleManager;
        }

        public async Task CreateRol(CreateRolDto createRolDto)
        {
            var response = await _roleManager.FindByNameAsync(createRolDto.Name);

            if (response != null) throw new ApiException("El rol ya existe.");

            var rol = new Rol();
            rol.Name = createRolDto.Name;
            await _roleManager.CreateAsync(rol);
        }

        public async Task<List<Rol>> GetRoles()
        {
            var roles =  await _roleManager.Roles.ToListAsync();
            return roles;
        }
    }
}
