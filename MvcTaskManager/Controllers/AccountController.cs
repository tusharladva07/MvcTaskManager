using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.Contracts.Messaging;
using MvcTaskManager.ServiceContracts;
using MvcTaskManager.ViewModels;
using System.Threading.Tasks;

namespace MvcTaskManager.Controllers
{
    [ApiController]
    
    public class AccountController : Controller
    {
        private IUserService _userService;
        public AccountController(IUserService userService)
        {
            _userService = userService;
        }
        [HttpPost]
        [Route("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody]LoginViewModel loginViewModel)
        {
            var user = await _userService.Authenticate(loginViewModel);
            if(user == null)
            {
                return BadRequest(new { message = "UserName And Password is Incorrect" });
            }
            return Ok(user);
        }
    }
}
