using ASPNetCoreWebApi1.Models;

namespace ASPNetCoreWebApi1.Services.Impl
{
    public class AuthenticationService
    {
        private IUserService _userService;
        private TokenService _tokenService;
        public AuthenticationService() {
            _userService = new UserService();
            _tokenService = new TokenService();
        }
        public string Authenticate(UserCredentials userCredentials)
        {
            _userService.ValidateCredentials(userCredentials);
            string securityToken = _tokenService.GetToken();

            return securityToken;
        }
    }
}
