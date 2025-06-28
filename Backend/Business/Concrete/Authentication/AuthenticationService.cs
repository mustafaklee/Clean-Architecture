using Business.Abstract.Authentication;
using Entities.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete.Authentication
{
    public class AuthenticationService : IAuthenticationService
    {
        public AuthenticationResponseDto Login(LoginRequestDto request)
        {
            return new AuthenticationResponseDto(Guid.NewGuid(), "firstname", "lastname", request.Email, "token");
        }

        public AuthenticationResponseDto Register(RegisterRequestDto request)
        {
            return new AuthenticationResponseDto(Guid.NewGuid(), "firstname", "lastname", request.Email, "token");
        }
    }
}
