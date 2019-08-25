using IdealPoultryApp.Models;

namespace IdealPoultryApp.Services
{
    public interface IUserService
    {
        bool IsUserValid(LoginModel model);
    }
}