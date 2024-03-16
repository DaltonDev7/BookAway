using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using BookAway.Infrastructure.Repositories.Generic;

namespace BookAway.Infrastructure.Repositories
{
    public class SexoRepository : BaseRepository<Sexo>, ISexoRepository
    {
        public SexoRepository(BookAwayContext context) : base(context)
        {
        }
    }
}
