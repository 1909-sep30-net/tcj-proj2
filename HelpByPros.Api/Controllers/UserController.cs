using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public UserController(ILogger<UserController> logger, IUserRepo userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }

        [HttpGet]
        public async Task<IEnumerable<Member>> GetAllMembers()
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


       /* [HttpPost]
        public async Task CreateAUser( )
        {
         _userRepo.AddMemberAsync();
            var x = _userRepo.GetMemberListAsync();
            return await x;
        }*/
    }
}
