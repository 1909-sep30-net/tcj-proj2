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
using System.Collections;

namespace HelpByPros.Test
{
    public class ForumControllerTest
    {
        Mock<IUserRepo> userRepo = new Mock<IUserRepo>();
        Mock<ISentMessage> sentMessage = new Mock<ISentMessage>();
        Mock<IForumRepo> forumrepo = new Mock<IForumRepo>();

        [Fact]
        public async Task TestShouldGetAForumModel()
        {
            var mockRepo = new Mock<IUserRepo>();
            Mock<IForumRepo> _forumrepo = new Mock<IForumRepo>();

            _forumrepo.Setup(r => r.GetQuestionAsync(It.IsAny<int>()))
                .Returns(Task.FromResult( new Question {
                    Category = "Math",
                    AuthorName = "Username",
                    Answered = false,
                    QuestionBody ="QuestionBody",
                    UserQuestion = "UserQuestion",
                    Id=1


                }
        ));

            _forumrepo.Setup(r => r.GetAnswerListAsync(It.IsAny<int>(), It.IsAny<int>(), It.IsAny<int>()))
                .Returns(Task.FromResult( new List<Answer>()));





            Mock<ILogger<ForumController>> logger = new Mock<ILogger<ForumController>>();
            var controller = new ForumController(logger.Object, mockRepo.Object, sentMessage.Object,_forumrepo.Object);

            var model = Assert.IsType<ForumModel>(await controller.Get(1));
            Assert.IsType<ForumModel>(model);
        }

    }
}
