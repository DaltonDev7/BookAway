
using Microsoft.AspNetCore.Identity;

namespace BookAway.Application.Dtos.Auth
{
    public class SignInResponseDto
    {
        public string? SuccessMessage { get; set; }
        public string? Errors { get; set; }
        public string token { get; set; }

        public UserResponseSignInDto User { get; set; }

    }
}
