using BookAway.Application.Interfaces.Generic;
using BookAway.Application.Interfaces.Repositories;
using BookAway.Application.Interfaces.Services;
using BookAway.Application.Services;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using BookAway.Infrastructure.Repositories;
using BookAway.Infrastructure.Repositories.Generic;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace BookAway
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddDependencyInjection(this IServiceCollection services, IConfiguration configuration)
        {

            var connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            services.AddDbContext<BookAwayContext>(db => db.UseSqlServer(connectionString));

            services.AddScoped(typeof(IBaseRepository<>), typeof(BaseRepository<>));
            services.AddTransient<IUnityOfWork, UnityOfWork>();


            //services
            services.AddScoped<IRoleServices, RoleServices>();
            services.AddScoped<ITokenServices, TokenServices>();
            services.AddScoped<IAuthServices, AuthServices>();
            services.AddScoped<IHotelServices, HotelServices>();
            services.AddScoped<ICiudadServices, CiudadServices>();
            services.AddScoped<IPaisServices, PaisServices>();
            services.AddScoped<IProvinciaServices, ProvinciaServices>();
            services.AddScoped<ISexoServices, SexoServices>();
            services.AddScoped<ITipoHabitacionServices, TipoHabitacionServices>();
            services.AddScoped<IHabitacionServices, HabitacionServices>();

            //repository
            services.AddScoped<IHotelRepository, HotelRepository>();
            services.AddScoped<IHabitacionRepository, HabitacionRepository>();

            //add identity
            services.AddIdentity<Usuario, Rol>( options =>
            {
                options.Password.RequiredLength = 6;
                options.Password.RequireLowercase = true;
                options.Password.RequireNonAlphanumeric = false;
                options.Password.RequireUppercase = true;
                options.SignIn.RequireConfirmedEmail = false;
                options.SignIn.RequireConfirmedPhoneNumber = false;
                options.SignIn.RequireConfirmedAccount = false;
            }).AddRoles<Rol>()
                .AddRoleManager<RoleManager<Rol>>()
                .AddEntityFrameworkStores<BookAwayContext>();

            //add authenticacion JWT
            services.AddAuthentication(options =>
            {
                options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
           .AddJwtBearer(options =>
           {
               options.TokenValidationParameters = new TokenValidationParameters
               {
                   ValidateIssuer = true,
                   ValidateAudience = true,
                   ValidateLifetime = true,
                   ValidateIssuerSigningKey = true,
                   ValidIssuer = "http://localhost:4200",
                   ValidAudience = "http://localhost:4200",
                   IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["JwtSettings:JwtKey"]))
               };
           });


            return services;
        }
    }
}
