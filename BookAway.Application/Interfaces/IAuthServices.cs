using BookAway.Application.Dtos.Auth;

namespace BookAway.Application.Interfaces
{
    public interface IAuthServices
    {
        Task<SignUpResponseDto> SignUp(SignUpDto payload);
        Task<SignInResponseDto> SignIn(SignInDto payload);
    }
}
