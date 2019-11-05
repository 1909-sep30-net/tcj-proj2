using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.Extensions.Logging;


namespace HelpByPros.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuestionController : ControllerBase
    {
        ///

        private readonly ILogger<QuestionController> _logger;
        private readonly IForumRepo _forumRepo;
        private readonly IUserRepo _userRepo;

        

        public QuestionController(ILogger<QuestionController> logger, IForumRepo forumRepo, IUserRepo userRepo)
        {
            _logger = logger;
            _forumRepo = forumRepo;
            _userRepo = userRepo;
        }

        /*
        // GET: api/Question
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return _forumRepo.;
        }
        */

        // GET: api/Question/5
        [HttpGet("{id}", Name = "GetA_Q")]
        //public async Task<Member> GetA(string username)
        public async Task<Question> GetA_Q(int id)
        {

                
                return await _forumRepo.GetQuestionAsync(id);


        }


        /// <summary>
        /// ask a generic question: used to test post.
        /// </summary>
        /// <param name="value"></param>
        
        // POST: api/Question
        [HttpPost]
        public async Task Post( [FromBody] string value)
        {

            Question theQuestion = new Question();

            theQuestion.UserQuestion = "Is this a test question?";
            theQuestion.QuestionBody = "I'm testing the question to be written to the database, so I'm asking this question, will it work?";
            theQuestion.Category = Category.ComputerScience;
            theQuestion.Author = _userRepo.GetAMemberAsync("member1") as IUser ; 
            

            await _forumRepo.AddQuestionToDBAsync(theQuestion);
        }

        // PUT: api/Question/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
