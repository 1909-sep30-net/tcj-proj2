using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace HelpByPros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RegisterController : ControllerBase
    {
        private readonly ILogger<RegisterController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;

        public RegisterController(ILogger<RegisterController> logger, IUserRepo userRepo, ISentMessage sentMessage)
        {
            _logger = logger;
            _userRepo = userRepo;
            _messageSender = sentMessage;

        }
        [HttpGet("{model}",Name = "GetRegister")]
        public RegisterModel GetRegister(RegisterModel model)
        {
            return model;
        }

        [HttpGet(Name = "Get")]
        /// [Route({"model": Register})]

        public RegisterModel Get()
        {
            RegisterModel model = new RegisterModel();
            return model;
        }
        //Post: api/Register
        [HttpPost]
        public async Task<ActionResult> CreateUser(RegisterModel model)
        {
            if (model.IsProfessional) {
                await _userRepo.AddProfessionalAsync(model.RegisterProfessional());
                    }
            else
            {
                await _userRepo.AddMemberAsync(model.RegisterMember());

            }
            return CreatedAtRoute("GetRegister", model);

        }

    }
}