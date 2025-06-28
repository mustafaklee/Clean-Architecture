using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Authentication
{
    public record AuthenticationResponseDto(
        Guid Id,
        string FirstName,
        string LastName,
        string Email,
        string Token
        );
}
