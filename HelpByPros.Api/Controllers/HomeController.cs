using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;


namespace HelpByPros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class HomeController : ControllerBase
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IForumRepo _forumRepo;

        public HomeController(ILogger<HomeController> logger, IForumRepo forumRepo)
        {
            _logger = logger;
            _forumRepo = forumRepo;
        }


        /// <summary>
        /// get a list of a list of a questions sorted by category
        /// 
        /// </summary>
        /// <returns></returns>
        /// home
        [HttpGet(Name ="GetHomeList")]
        public IEnumerable<IEnumerable<Question>> GetHomePage()
        {

                List<List<Question>> QList = new List<List<Question>>();
                
                foreach (var x in Enum.GetValues(typeof(Category)).OfType<Category>().ToArray())
                {
                    
                   var y= _forumRepo.GetQuestionList(x, 0, 10);
                    foreach( var q in y)
                    {
                        q.Author = null;
                    }
                
                QList.Add(y);
                }
                return QList;
        }

        /// <summary>
        /// get a list of a list of a questions sorted by category
        /// 
        /// </summary>
        /// <returns></returns>
        ///  home/math
        [HttpGet("category/{category}", Name = "GetOneCatgoryList")]

        public IEnumerable<QuestionModel> GetOneCatgoryList(string category)
        {
            var x = new List<QuestionModel>();
            var c = new QuestionModel();
            var y = _forumRepo.GetQuestionList((Category)Enum.Parse(typeof(Category), category), 0, 10);
            foreach (var q in y)
            {
                q.Author = null;
                x.Add(c.MapToQuestion(q));
            }
            return x ;
        }

        [HttpGet("category/{category}/{starting}", Name = "GetOneCatgoryListStarting")]

        public IEnumerable<QuestionModel> GetOneCatgoryListStarting(string category, int starting)
        {
            var x = new List<QuestionModel>();
            var c = new QuestionModel();
            var y = _forumRepo.GetQuestionList((Category)Enum.Parse(typeof(Category), category), starting, 10);
            foreach (var q in y)
            {
                q.Author = null;
                x.Add(c.MapToQuestion(q));
            }
            return x;
        }



        [HttpGet("Starting/{starting}", Name = "GetMoreListUsingStarting")]
        public List<List<Question>> GetMoreListUsingStarting(int starting)
        {

            List<List<Question>> QList = new List<List<Question>>();
            
            foreach (var x in Enum.GetValues(typeof(Category)).OfType<Category>().ToArray())
            {
                //return a list of question based on a category
                QList.Add(_forumRepo.GetQuestionList(x, starting, 10));
            }
            return QList;
        }




    }
}