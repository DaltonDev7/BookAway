

using AutoMapper;
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Habitacion;
using BookAway.Application.Dtos.Hotel;
using BookAway.Domain.Entities;

namespace BookAway.Application.Mapping
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<AddUpdateHotelDto, Hotel>();
            CreateMap<AddHabitacionDto, Habitacion>();
            CreateMap<Hotel, HotelListDto>();
        }
    }
}
