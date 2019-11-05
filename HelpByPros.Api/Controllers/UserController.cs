using System.Collections.Generic;
using System.Threading.Tasks;
using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace HelpByPros.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {


        private readonly ILogger<UserController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;
     

        public UserController(ILogger<UserController> logger, IUserRepo userRepo, ISentMessage sentMessage)
        {
            TwillioAPICalls calls = new TwillioAPICalls();

            _logger = logger;
            _userRepo = userRepo;
            _messageSender = sentMessage;

        }
        /// <summary>
        /// only admin are allowed this function;
        /// </summary>
        /// <param name="userName"></param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IEnumerable<Member>> GetAllMembers(string userName)
        {

            var x = _userRepo.GetMemberListAsync();
            return await x;
        }
        // GET: api/GetAMember/username
        [HttpGet("{username}", Name = "GetA")]
        public async Task<Member> GetA(string username)
        {

            var x = _userRepo.GetAMemberAsync(username);
            return await x;
        }
        //Post: api/user
        [HttpPost]
        public async Task CreateMember(RegisterViewModel model)
        {
            await _userRepo.AddMemberAsync(model.RegisterMember);
        }
        //Post: api/user
        [HttpPost]
        public async Task CreateProfessonal(RegisterViewModel model)
        {
            await _userRepo.AddProfessionalAsync(model.RegisterProfessionl);
        }


    }
}
