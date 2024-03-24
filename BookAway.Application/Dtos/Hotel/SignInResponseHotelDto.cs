

namespace BookAway.Application.Dtos.Hotel
{
    public class SignInResponseHotelDto
    {
        public string? SuccessMessage { get; set; }
        public string? Errors { get; set; }
        public string Token { get; set; }

        public HotelResponseSignInDto Hotel { get; set; }
    }
}
