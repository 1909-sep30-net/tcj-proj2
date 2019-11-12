using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace HelpByPros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;

        public UserController(ILogger<UserController> logger, IUserRepo userRepo, ISentMessage sentMessage)
        {
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            _messageSender = sentMessage ?? throw new ArgumentNullException(nameof(sentMessage));

        }
        [HttpGet("DisplayUserModel",Name = "DisplayingUserModel")]
        public RegisterModel DisplayingUserModel(RegisterModel model)
        {
            return model;
        }

        [HttpGet("EmptyModel",Name = "GetRegisterModel")]
        public RegisterModel Get()
        {
            RegisterModel model = new RegisterModel();
            return model;
        }

        [HttpGet("{username}", Name = "getCharacterModel")]
        public async Task<RegisterModel> Get(string  username)
        {
            RegisterModel model = new RegisterModel();
            try
            {
                var prof = await _userRepo.GetAProfessionalAsync(username); 
                model.IsProfessional = true;
                model.FirstName = prof.FirstName;
                model.LastName = prof.LastName;
                model.Phone = prof.Phone;
                model.Summary = prof.Summary;
                model.YearsOfExp = prof.YearsOfExp;
                model.Username = prof.Username;
                model.Credential = prof.Credential;
                model.Category = prof.Category;
                model.Email = prof.Email;
            }
            catch
            {
            
                    var member = await _userRepo.GetAMemberAsync(username);
                    model.IsProfessional = false;
                    model.FirstName = member.FirstName;
                    model.LastName = member.LastName;
                    model.Phone = member.Phone;
                    model.Username = member.Username;
                    model.Email = member.Email;
            
    
            }
         
            return model;
        }
        //Post: api/Register

        [HttpPost("CreateUser", Name = "CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] RegisterModel model)
        {
        
                if (model.IsProfessional)
                {   
                    await _userRepo.AddProfessionalAsync(model.RegisterProfessional());
                }
                else
                {
                    await _userRepo.AddMemberAsync(model.RegisterMember());

                }
            return Ok();        

        }

        [HttpPut("EditUser", Name = "EditUser")]
        public async Task<ActionResult> EditUsers([FromBody] RegisterModel model)
        {
            try
            {
                if (model.IsProfessional)
                {
                    await _userRepo.ModifyProfessionalInfoAsync(model.RegisterProfessional());
                    return StatusCode(StatusCodes.Status202Accepted);
                }
                else
                {
                    await _userRepo.ModifyMemberInfoAsync(model.RegisterMember());
                    return StatusCode(StatusCodes.Status202Accepted);

                }
            }catch{
                
                return StatusCode(StatusCodes.Status400BadRequest);
            }
           
        }

        [AllowAnonymous]
        [HttpPut("UpVote/{ansID}/{ansPoint}", Name = "UpVote")]
        public async Task<ActionResult> UpVoteAnswer(int ansID, int ansPoint)
        {
            try
            {
                await _userRepo.ModifyAnswerUpVotes(ansPoint,ansID );
                return StatusCode(StatusCodes.Status202Accepted);


            }
            catch
            {
                Response.StatusCode = 400;
                return StatusCode(StatusCodes.Status400BadRequest);

            }

        }
        [AllowAnonymous]
        [HttpPut("DownVote/{ansID}/{ansPoint}", Name = "DownVote")]
        public async Task<ActionResult> DownVoteAnswer(int ansID, int ansPoint)
        {
            try
            {
                await _userRepo.ModifyAnswerDownVotes(ansPoint, ansID);
                return StatusCode(StatusCodes.Status202Accepted);

            }
            catch
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

        }

    }
}