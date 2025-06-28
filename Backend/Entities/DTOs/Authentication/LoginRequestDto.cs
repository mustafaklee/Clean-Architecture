using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.DTOs.Authentication
{
    public record LoginRequestDto(
        string Email,
        string Password
        );
}
