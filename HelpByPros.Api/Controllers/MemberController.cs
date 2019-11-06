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
    public class MemberController : ControllerBase
    {


        private readonly ILogger<MemberController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;
     

        public MemberController(ILogger<MemberController> logger, IUserRepo userRepo, ISentMessage sentMessage)
        {
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
        [HttpGet("{username}", Name = "GetAMember")]
        public async Task<Member> GetAMember(string username)
        {
            try
            {
                var x = _userRepo.GetAMemberAsync(username);
                return await x;
            }
            catch
            {
                BadRequest();
                throw;
            }
        }

 
     

    }
}
