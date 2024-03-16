using Microsoft.AspNetCore.Identity;

namespace BookAway.Application.Dtos.Auth
{
    public class SignUpResponseDto
    {
        public string? SuccessMessage { get; set; }
        public List<IdentityError>? Errors { get; set; }
    }
}
