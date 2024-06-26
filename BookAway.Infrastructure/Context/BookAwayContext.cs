﻿
using BookAway.Domain.Entities;
using BookAway.Infrastructure.EntityConfigurations;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookAway.Infrastructure.Context
{
    public class BookAwayContext : IdentityDbContext<Usuario, Rol, int, IdentityUserClaim<int>, RolUsuario, IdentityUserLogin<int>,
    IdentityRoleClaim<int>, IdentityUserToken<int>>
    {
        public BookAwayContext(DbContextOptions<BookAwayContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new RolUsuarioConfiguration());
            builder.ApplyConfiguration(new UsuarioConfiguration());
            builder.ApplyConfiguration(new SexoConfiguration());
            builder.ApplyConfiguration(new PaisConfiguration());
            builder.ApplyConfiguration(new CiudadConfiguration());
            builder.ApplyConfiguration(new ProvinciaConfiguration());
            builder.ApplyConfiguration(new HotelConfiguration());
            builder.ApplyConfiguration(new HotelServicioConfiguration());
            builder.ApplyConfiguration(new HabitacionConfiguration());
            builder.ApplyConfiguration(new TipoHabitacionConfiguration());
            builder.ApplyConfiguration(new EstadoReservaConfiguration());
            builder.ApplyConfiguration(new ReservaConfiguration());
        }


        public DbSet<Provincia> Provincia { get; set; }
        public DbSet<Ciudad> Ciudad { get; set; }
        public DbSet<Hotel> Hotel { get; set; }
        public DbSet<Pais> Pais { get; set; }
        public DbSet<Reserva> Reserva { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<EstadoReserva> EstadoReserva { get; set; }
        public DbSet<Sexo> Sexo { get; set; }
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Habitacion> Habitacion { get; set; }
        public DbSet<Habitacion> TipoHabitacion { get; set; }
        public DbSet<HotelServicio> HotelServicio { get; set; }
        public DbSet<RolUsuario> RolUsuario { get; set; }


    }
}
