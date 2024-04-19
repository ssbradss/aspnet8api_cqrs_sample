using ASPNetCoreWebApi1.Models;
using Microsoft.VisualStudio.Services.WebApi.Jwt;
using System.Security.Authentication;

namespace ASPNetCoreWebApi1.Services.Impl
{
    public class UserService : IUserService
    {
        private readonly IEnumerable<UserCredentials> users;

        public UserService()
        {
            users = new List<UserCredentials>
        {
            new UserCredentials
            {
                Username = "john.doe",
                Password = "john.password"
            }
        };
        }
        public void ValidateCredentials(UserCredentials userCredentials)
        {
            bool isValid =
                users.Any(u =>
                    u.Username == userCredentials.Username &&
                    u.Password == userCredentials.Password);

            if (!isValid)
            {
                throw new InvalidCredentialsException("ValidateCredentials");
            }
        }
    }
}
