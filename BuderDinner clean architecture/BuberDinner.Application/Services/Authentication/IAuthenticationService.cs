
namespace BuberDinner.Application.Services.Authentication
{
    public interface IAuthenticationService
    {

        AuthenticationResult register(string firstName, string lastName, string email, string password);
        AuthenticationResult login(string email, string password);

    }
}
