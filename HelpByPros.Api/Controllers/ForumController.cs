using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using System;
using System.Linq;

namespace HelpByPros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    [Authorize]
    public class ForumController : ControllerBase
    {
        private readonly ILogger<ForumController> _logger;
        private readonly IUserRepo _userRepo;
        private readonly ISentMessage _messageSender;
        private readonly IForumRepo _forumRepo;
        /// <summary>
        /// The forum repo suppose to get 1 question and all the answer, if any, 
        /// </summary>
        /// <param name="logger"></param>
        /// <param name="userRepo"></param>
        /// <param name="sentMessage"></param>
        /// <param name="forumRepo"></param>
        public ForumController(ILogger<ForumController> logger, IUserRepo userRepo, ISentMessage sentMessage, IForumRepo forumRepo)
        {
            _forumRepo = forumRepo ?? throw new ArgumentNullException(nameof(sentMessage));
            _logger = logger ?? throw new ArgumentNullException(nameof(logger));
            _userRepo = userRepo ?? throw new ArgumentNullException(nameof(userRepo));
            _messageSender = sentMessage ?? throw new ArgumentNullException(nameof(sentMessage));

        }


        [HttpGet("GetQuestionID/{Qid}")]       
        public async Task<ForumModel> Get(int Qid)
        {
            ForumModel forumModel = new ForumModel();

            try
            {
                forumModel.Question = await _forumRepo.GetQuestionAsync(Qid);
                forumModel.Question.Author = null;
                forumModel.Answers = (List<Answer>)await _forumRepo.GetAnswerListAsync(Qid, 0, 100);
                foreach(Answer ans in forumModel.Answers)
                ans.Author = null;

                //Response.StatusCode = 200;

                return forumModel;
            }
            catch
            {
                Response.StatusCode = 400;
                return forumModel;

            }
        }



        /// <summary>
        /// Question already contain a reference link to a user in DB
        /// </summary>
        /// <param name="q"></param>
        /// <returns></returns>
        ///         [HttpGet("category/{category}", Name = "GetOneCatgoryList")]

        [HttpPost("AddQuestion", Name = "addquestion")]
        public async Task AddQuestion([FromBody] QuestionModel q)
        {
            Question x = new Question();
            x.Category = q.Category;
            x.AuthorName = q.Username;
            x.Answered = false;
            x.QuestionBody = q.QuestionBody;
            x.UserQuestion = q.UserQuestion;
            x.Author = await _userRepo.GetAUserAsync(q.Username);
            x.Id = 0;
            Response.StatusCode = 201;
            try
            {
                await _forumRepo.AddQuestionAsync(x);
                
                
                _messageSender.SentMessageThruPhoneCreate("Someone Posted a Question in your expertise!",await _userRepo.GetPhoneListForProfessionalExpertise(q.Category));

            }
            catch
            {
                Response.StatusCode = 400;
            }
            

        }

        [HttpPost("AddAnswer", Name ="addanswer")]
        public async Task AddAnswer([FromBody]AnswerModel a)
        {
            Answer x = new Answer();
            x.AnsQuestionID = a.QuestionID;
            try
            {
                x.Author = await _userRepo.GetAUserAsync(a.Username);
                x.ID = 0;
                x.AnswerText = a.AnswerBody;
                x.UpVote = a.Upvote;
                x.DownVote = a.DownVote;
                x.Source = a.Source;
                Response.StatusCode = 201;         
                await _forumRepo.AddAnswerAsync(x);
                List<string> y = new List<string>();
                y.Add(await _userRepo.GetAuthorOfQuestion(a.QuestionID));
                _messageSender.SentMessageThruPhoneCreate("Someone Answered Your Question!",y );

            }
            catch
            {
                Response.StatusCode = 400;
            }
           

        }
        //        [HttpPost("AddAnswer", Name ="addanswer")]

        [HttpPut("EditQuestion", Name = "EditQuestion")]
        public async Task EditQuestion([FromBody] QuestionModel q)
        {
           Question x = new Question(); 
            x.Category = q.Category;
            x.AuthorName = q.Username;
            x.Answered = false;
            x.QuestionBody = q.QuestionBody;
            x.UserQuestion = q.UserQuestion;
            x.Author = await _userRepo.GetAUserAsync(q.Username);
            x.Id = q.QuestionID;
            Response.StatusCode = 202;
            try
            {
                await _userRepo.ModifyQuestionAsync(x);
            }
            catch
            {
                Response.StatusCode = 400;
            }
        }

        [HttpPut("EditAnswer", Name = "EditAnswer")]
        public async Task EditAnswer([FromBody] AnswerModel a)
        {
            Answer x = new Answer();
            x.AnsQuestionID = a.QuestionID;
            try
            {
                x.Author = await _userRepo.GetAUserAsync(a.Username);
                x.ID = a.AnswerId;
                x.AnswerText = a.AnswerBody;
                x.UpVote = a.Upvote;
                x.DownVote = a.DownVote;
                x.Source = a.Source;                
                await _userRepo.ModifyAnswerAsync(x);
                Response.StatusCode = 202;

            }
            catch
            {
                Response.StatusCode = 400;
            }
        }

        [HttpDelete("DeleteAnswer/{answerID}", Name = "DeleteAnswer")]
        public async Task DeleteAnswer( int answerID)
        {
            try { 
            
                await _userRepo.DeleteAAnswerAsync(answerID);
                Response.StatusCode = 204;

            }
            catch
            {
                Response.StatusCode = 400;
            }
        }
        [HttpDelete("DeleteQuestion/{QuestionID}", Name = "DeleteQuestion")]
        public async Task DeleteQuestion(int questionID)
        {
            try
            {

                await _userRepo.DeleteQuestionAsync(questionID);
                Response.StatusCode = 204;

            }
            catch
            {
                Response.StatusCode = 400;
            }
        }
        //test

        [HttpGet("GetEmptyModel", Name = "Den")]
        public QuestionModel DeleteQuedstion()
        {
            return new QuestionModel();
        }

        [HttpGet("Category")]
        public List<string> GetCategory()
        {
            List<string> ListOfCategory = new List<string>();
            foreach (var x in Enum.GetValues(typeof(Category)).OfType<Category>().ToArray())
            {
                ListOfCategory.Add(x.ToString());
            }
            return ListOfCategory;
        }




    }
}