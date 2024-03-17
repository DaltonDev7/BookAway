
using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using BookAway.Infrastructure.Repositories.Generic;

namespace BookAway.Infrastructure.Repositories
{
    public class CiudadRepository : BaseRepository<Ciudad>, ICiudadRepository
    {
        public CiudadRepository(BookAwayContext context) : base(context)
        {
        }
    }
}
