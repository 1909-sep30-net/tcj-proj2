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
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;

        public UserController(ILogger<UserController> logger, IUserRepo userRepo, ISentMessage sentMessage)
        {
            _logger = logger;
            _userRepo = userRepo;
            _messageSender = sentMessage;

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
            }
            catch
            {
                var member = await _userRepo.GetAMemberAsync(username);
                model.IsProfessional = false ;
                model.FirstName = member.FirstName;
                model.LastName = member.LastName;
                model.Phone = member.Phone;        
                model.Username = member.Username;
            }
            return model;
        }
        //Post: api/Register

        [HttpPost("CreateUser", Name = "CreateUser")]
        public async Task<ActionResult> CreateUser([FromBody] RegisterModel model)
        {
            if (model.IsProfessional) {
                await _userRepo.AddProfessionalAsync(model.RegisterProfessional());
                    }
            else
            {
                await _userRepo.AddMemberAsync(model.RegisterMember());

            }
            return CreatedAtRoute("DisplayUserModel", model);

        }

        [HttpPut("EditUser", Name = "EditUser")]
        public async Task EditUsers([FromBody] RegisterModel model)
        {
            try
            {
                if (model.IsProfessional)
                {
                    await _userRepo.ModifyProfessionalInfoAsync(model.RegisterProfessional());
                    Response.StatusCode = 202;

                }
                else
                {
                    await _userRepo.ModifyMemberInfoAsync(model.RegisterMember());
                    Response.StatusCode = 202;


                }
            }catch{
                Response.StatusCode = 400;
            }
           


        }

    }
}