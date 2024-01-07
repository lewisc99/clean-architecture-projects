using BuberDinner.Application.Services.Authentication;
using BuberDinner.Contracts.Authentication;
using Microsoft.AspNetCore.Mvc;

namespace BuberDinner.Api.Controllers
{
    [ApiController]
    [Route("auth")]
    public class AuthenticationController : ControllerBase
    {

        private readonly IAuthenticationService _authenticationService;


        public AuthenticationController(IAuthenticationService authenticationService)
        {
            _authenticationService = authenticationService;
        }


        [HttpPost("register")]
        public IActionResult Register(RegisterRequest request)
        {

            var authResult = _authenticationService.register(request.FirstName, request.lastName, request.Email, request.Password);

            var response = new AuthenticationResponse(
                authResult.id,
                authResult.firstName,
                authResult.lastName,
                authResult.Email,
                authResult.Token
                );


            return Ok(response);
        }


        [HttpPost("login")]
        public IActionResult Login(LoginRequest request)
        {

            var authResult = _authenticationService.login(request.Email, request.Password);

            var response = new AuthenticationResponse(
                authResult.id,
                authResult.firstName,
                authResult.lastName,
                authResult.Email,
                authResult.Token
                );


            return Ok(response);
        }

    }

}
