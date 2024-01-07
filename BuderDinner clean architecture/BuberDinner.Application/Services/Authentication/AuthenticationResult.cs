using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuberDinner.Application.Services.Authentication
{
    public record AuthenticationResult(Guid id, string firstName, string lastName, string Email, string Token);
}
