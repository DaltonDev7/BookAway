
using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using BookAway.Infrastructure.Repositories.Generic;

namespace BookAway.Infrastructure.Repositories
{
    public class ProvinciaRepository : BaseRepository<Provincia>, IProvinciaRepository
    {
        public ProvinciaRepository(BookAwayContext context) : base(context)
        {
        }
    }
}
