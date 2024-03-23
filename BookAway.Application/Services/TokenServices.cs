using BookAway.Application.Interfaces.Services;
using BookAway.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace BookAway.Application.Services
{
    public class TokenServices : ITokenServices
    {
        private readonly IConfiguration _configuration;
        private readonly UserManager<Usuario> _userManager;

        public TokenServices(IConfiguration configuration, UserManager<Usuario> userManager)
        {
            _configuration = configuration;
            _userManager = userManager;
        }

        public async Task<string> GenerateToken(Usuario usuario)
        {
            var secretValue = _configuration.GetSection("JwtSettings:Jwt").Value;
            var secretKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretValue));
            var signingCredentials = new SigningCredentials(secretKey, SecurityAlgorithms.HmacSha256);

            //creamos los claims para crear el token
            var utcNow = DateTime.UtcNow.AddMinutes(-240);
            var claims = new List<Claim>
                {
                    new Claim(ClaimTypes.Name, usuario.Nombres),
                    new Claim(ClaimTypes.Email,usuario.Email),
                };

            //obtenemos los roles del usuario
            var userRoles = await _userManager.GetRolesAsync(usuario);

            foreach (var userRole in userRoles)
            {
                var rolesClaims = new List<Claim>
                    {
                        new Claim("RoleName", userRole),
                    };
                claims.AddRange(rolesClaims);
            }

            //creamos el token
            var jwt = new JwtSecurityToken(
                 signingCredentials: signingCredentials,
                 claims: claims,
                 notBefore: utcNow,
                 expires: DateTime.Now.AddHours(12),
                 issuer: "http://localhost:4200",
                 audience: "http://localhost:4200"
             );

            var tokenString = new JwtSecurityTokenHandler().WriteToken(jwt);

            return tokenString;
        }
    }
}
