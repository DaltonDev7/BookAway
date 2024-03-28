using BookAway.Application.Dtos.TipoHabitacion;
using BookAway.Application.Interfaces.Common;
using BookAway.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookAway.Application.Interfaces.Services
{
    public interface ITipoHabitacionServices : IService<TipoHabitacion, AddTipoHabitacionDto, UpdateTipoHabitacionDto>
    {
    }
}
