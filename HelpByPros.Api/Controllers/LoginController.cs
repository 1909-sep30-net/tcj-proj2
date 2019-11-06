using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelpByPros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoginController : ControllerBase
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUserRepo _userRepo;

        public LoginController(ILogger<LoginController> logger, IUserRepo userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
     

        }

    }
}