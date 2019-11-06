using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpByPros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ForumController : ControllerBase
    {
        private readonly ILogger<ForumController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;

        public ForumController(ILogger<ForumController> logger, IUserRepo userRepo, ISentMessage sentMessage)
        {
            _logger = logger;
            _userRepo = userRepo;
            _messageSender = sentMessage;

        }


       /* [HttpGet(Name = "GetHomeView")]
        public ForumModel GetHomeView(Question question, List<Answer> answer)
        {
            ForumModel m = new ForumModel();
            m.Question = question;
            m.Answers = answer;

            return m;
        }*/


       

    }
}