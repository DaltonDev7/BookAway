﻿
using BookAway.Application.Dtos;
using BookAway.Application.Dtos.Auth;
using BookAway.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;

namespace BookAway.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AuthenticationController : ControllerBase
    {
        private readonly IAuthServices _authenticationService;

        public AuthenticationController(IAuthServices authenticationService)
        {
            _authenticationService = authenticationService;
        }

        [HttpPost]
        [Route("SignUp")]
        public async Task<IActionResult> SignUp(SignUpDto signUpDto)
        {
            var response = await _authenticationService.SignUp(signUpDto);
            return Ok(new ApiResponseDto<SignUpResponseDto>(response));
        }

        [HttpPost]
        [Route("SignIn")]
        public async Task<IActionResult> SignIn(SignInDto signInDto)
        {
            var response = await _authenticationService.SignIn(signInDto);
            return Ok(new ApiResponseDto<SignInResponseDto>(response));
        }


    }
}
