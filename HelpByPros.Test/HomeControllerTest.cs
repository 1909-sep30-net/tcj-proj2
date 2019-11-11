using HelpByPros.Api.Controllers;
using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.Extensions.Logging;
using Moq;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace HelpByPros.Test
{
    public class HomeControllerTest
    {
        //Mock<IForumRepo> forumRepo = new Mock<IForumRepo>();

        //[Fact]
        //public async void GetHomPageShouldReturnQuestionList()
        //{
        //    var mockRepo = new Mock<IForumRepo>();
        //    mockRepo.Setup(q => q.AddQuestionAsync(It.IsAny<Question>()));
        //    Mock<ILogger<HomeController>> logger = new Mock<ILogger<HomeController>>();
        //    var controller = new HomeController(logger.Object, mockRepo.Object);

        //    var questionList = controller.GetHomePage();
        //    Assert.NotEmpty(questionList);
        //}
    }
}
