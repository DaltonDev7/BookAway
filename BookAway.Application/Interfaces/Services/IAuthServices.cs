using BookAway.Application.Dtos.Auth;

namespace BookAway.Application.Interfaces.Services
{
    public interface IAuthServices
    {
        Task<SignUpResponseDto> SignUp(SignUpDto payload);
        Task<SignInResponseDto> SignIn(SignInDto payload);
    }
}
