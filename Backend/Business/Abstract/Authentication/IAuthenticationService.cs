using Entities.DTOs.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract.Authentication
{
    public interface IAuthenticationService
    {
        AuthenticationResponseDto Login(LoginRequestDto request);
        AuthenticationResponseDto Register(RegisterRequestDto request);

    }
}
