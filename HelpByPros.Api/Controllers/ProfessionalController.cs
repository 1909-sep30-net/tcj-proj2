using System.Collections.Generic;
using System.Threading.Tasks;
using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelpByPros.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProfessionalController : ControllerBase
    {


        private readonly ILogger<ProfessionalController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;


        public ProfessionalController(ILogger<ProfessionalController> logger, IUserRepo userRepo, ISentMessage sentMessage)
        {
            _logger = logger;
            _userRepo = userRepo;
            _messageSender = sentMessage;

        }
        [HttpGet("{username}", Name = "GetAProfessional")]
        public async Task<Professional> GetAProfessional(string username)
        {

            var x = _userRepo.GetAProfessionalAsync(username);
            return await x;
        }
        public string  GetAllMembers()
        {

            return "sda";
        }



    }
}
