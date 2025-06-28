using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Authentication
{
    public record RegisterRequestDto(
        string FirstName,
        string LastName,
        string Email,
        string Password
        );
}
