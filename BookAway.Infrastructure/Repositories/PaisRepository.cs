

using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using BookAway.Infrastructure.Repositories.Generic;

namespace BookAway.Infrastructure.Repositories
{
    public class PaisRepository : BaseRepository<Pais>, IPaisRepository
    {
        public PaisRepository(BookAwayContext context) : base(context)
        {
        }
    }
}
