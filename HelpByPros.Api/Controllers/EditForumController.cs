using System;
using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;


namespace HelpByPros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]


    public class EditForumController : ControllerBase
    {
      /*  private readonly ILogger<EditForumController> _logger;
        private readonly IUserRepo _userRepo;

        public EditForumController(ILogger<EditForumController> logger, IUserRepo userRepo)
        {
            _logger = logger;
            _userRepo = userRepo;
        }


       

        [HttpPut]
        [Authorize]
        public async Task EditQuestion(Question a, string username)
        {
            await _userRepo.ModifyQuestion(a, username);
            Response.StatusCode = 202;
        }

        [HttpDelete("{answerID}")]
        [Authorize]

        public async Task DelteAnswer(int answerID, string username)
        {
            await _userRepo.DeleteAAnswerAsync(answerID, username);
            Response.StatusCode = 202;

        }
        [HttpDelete("{questionID}")]
        [Authorize]
        public async Task DeletQuestion(int questionID, string username)
        {
            await _userRepo.DeleteQuestionAsync(questionID, username);
            Response.StatusCode = 202;

        }*/
    }
}