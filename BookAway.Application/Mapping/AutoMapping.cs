

using AutoMapper;
using BookAway.Application.Dtos;
using BookAway.Domain.Entities;

namespace BookAway.Application.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AddUpdateHotelDto, Hotel>();
        }
    }
}
