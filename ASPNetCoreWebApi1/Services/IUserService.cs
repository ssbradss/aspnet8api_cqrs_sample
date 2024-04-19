using ASPNetCoreWebApi1.Models;

namespace ASPNetCoreWebApi1.Services
{
    public interface IUserService
    {
        void ValidateCredentials(UserCredentials userCredentials);
    }
}
