using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
        [HttpGet(Name ="GetHome")]
        public List<List<Question>> GetHomePage()
        {

                List<List<Question>> QList = new List<List<Question>>();
                foreach (var x in Enum.GetValues(typeof(Category)).OfType<Category>().ToArray())
                {
                    QList.Add(_forumRepo.GetQuestionList(x, 0, 100));
                }
            return QList;
        }
    /*  [HttpGet("{ContinueList}")]
        public List<List<Question>> GetMoreList(List<List<Question>> ContinueList)
        {

            List<List<Question>> QList = new List<List<Question>>();
            foreach (var x in Enum.GetValues(typeof(Category)).OfType<Category>().ToArray())
            {
                QList.Add(_forumRepo.GetQuestionList(x, 100, 50));
            }
            return QList;
        }*/
        
        [HttpGet("{starting}", Name = "GetMoreListUsingStarting")]

        public List<List<Question>> GetMoreListUsingStarting(int starting)
        {

            List<List<Question>> QList = new List<List<Question>>();
            foreach (var x in Enum.GetValues(typeof(Category)).OfType<Category>().ToArray())
            {
                QList.Add(_forumRepo.GetQuestionList(x, starting, 50));
            }
            return QList;
        }
        

    
    }
}