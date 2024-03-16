
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BookAway.Infrastructure.Context
{
    public class BookAwayContext : IdentityDbContext
    {
        public BookAwayContext(DbContextOptions options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {

        }


    }
}
