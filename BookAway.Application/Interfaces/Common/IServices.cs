using BookAway.Application.Dtos;
using BookAway.Domain.Entities.Common;


namespace BookAway.Application.Interfaces.Common
{
    public interface IService<TEntity, TCreate, TUpdate> where TCreate : class where TUpdate : class where TEntity : BaseEntity
    {
        Task<ApiResponseDto<string>> Create(TCreate dto);
        Task<ApiResponseDto<string>> Update(TUpdate dto);
        Task<TEntity> GetById(int id);
        Task<List<TEntity>> GetAll();
        Task<ApiResponseDto<string>> Delete(int id);
    }
}
