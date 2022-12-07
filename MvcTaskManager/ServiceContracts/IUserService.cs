using MvcTaskManager.Identity;
using MvcTaskManager.ViewModels;
using System.Threading.Tasks;

namespace MvcTaskManager.ServiceContracts
{
    public interface IUserService
    {
        Task<ApplicationUser> Authenticate(LoginViewModel loginViewModel);
    }
}
