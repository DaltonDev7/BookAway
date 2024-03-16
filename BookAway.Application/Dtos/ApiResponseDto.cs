

namespace BookAway.Application.Dtos
{
    public class ApiResponseDto<T>
    {
        public bool Success { get; set; }
        public string? ErrorMessage { get; set; }

        public T? Data { get; set; }

        public ApiResponseDto(bool success = true)
        {
            Success = success;
        }

        public ApiResponseDto(T data, bool success = true)
        {
            Data = data;
            Success = success;
        }
       
    }
}
