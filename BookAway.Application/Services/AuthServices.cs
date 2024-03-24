using BookAway.Application.Dtos.Auth;
using BookAway.Application.Exception;
using BookAway.Domain.Constants;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using System.Net;
using BookAway.Application.Interfaces.Services;
using System.Security.Claims;

namespace BookAway.Application.Services
{
    public class AuthServices : IAuthServices
    {
        private readonly UserManager<Usuario> _userManager;
        private readonly SignInManager<Usuario> _signInManager;
        private readonly ITokenServices _tokenServices;

        public AuthServices(UserManager<Usuario> userManager, SignInManager<Usuario> signInManager, ITokenServices tokenServices)
        {
            _userManager = userManager;
            _signInManager = signInManager;
            _tokenServices = tokenServices;
        }

        public async Task<SignInResponseDto> SignIn(SignInDto payload)
        {
            //verificamos el usuario si existe
            var user = await _userManager.FindByEmailAsync(payload.Email);
            if (user == null) throw new ApiException("Este usuario no existe", (int)HttpStatusCode.NotFound);

            //Verificando, contrase;a. e email
            var result = await _signInManager.PasswordSignInAsync(user, payload.Password, isPersistent: false, lockoutOnFailure: true);

            var token = await _tokenServices.GenerateToken(user);

            //obtenemos los roles del usuario
            var userRoles = await _userManager.GetRolesAsync(user);
            string rolUser = "";

            foreach (var userRole in userRoles)
            {
                rolUser = userRole;
            }

            if (result.Succeeded && token != null)
            {
                return new SignInResponseDto()
                { 
                    Errors = null, 
                    User = new UserResponseSignInDto()
                    {
                        Apellidos = user.Apellidos,
                        Nombres = user.Nombres,
                        IdSexo = user.IdSexo,
                        Rol = rolUser
                    },
                    token = token
                };
            }

            return new SignInResponseDto() { Errors = "Credenciales invalidos"};
        }


        public async Task<SignUpResponseDto> SignUp(SignUpDto payload)
        {
            Usuario? finduser = await _userManager.FindByEmailAsync(payload.Email);
            if (finduser != null) throw new ApiException("Este correo ya esta registrado");

            //creamos el usuario
            var usuario = new Usuario
            {
                Nombres = payload.Nombres,
                Apellidos = payload.Apellidos,
                Email = payload.Email,
                Contacto = payload.Contacto,
                IdSexo = payload.IdSexo,
                Identificacion = payload.Identificacion,
                UserName = payload.Nombres+payload.Apellidos,
                Estado = true
            };

            var response = await _userManager.CreateAsync(usuario, payload.Password);

            if (response.Succeeded)
            {
                var userCreated = await _userManager.FindByEmailAsync(usuario.Email);

                if (userCreated != null) await _userManager.AddToRoleAsync(usuario, RolesConstants.Usuario);

                return new SignUpResponseDto() { SuccessMessage = "Usuario registrado correctamente.", Errors = null };
            }
            else
            {
                return new SignUpResponseDto() { Errors = response.Errors.ToList(), SuccessMessage = null };
            }

        }
    }
}
