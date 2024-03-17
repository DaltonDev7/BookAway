

using BookAway.Application.Interfaces.Repositories;
using BookAway.Domain.Entities;
using BookAway.Infrastructure.Context;
using BookAway.Infrastructure.Repositories.Generic;

namespace BookAway.Infrastructure.Repositories
{
    public class HotelRepository : BaseRepository<Hotel>, IHotelRepository
    {
        public HotelRepository(BookAwayContext context) : base(context)
        {

        }


        public bool ValidateRNC(string rnc)
        {
            return _dbSet.Any(x => x.RNC == rnc);
        }

        public bool ValidateEmail(string email)
        {
            return _dbSet.Any(y => y.Email == email);
        }


    }

}
