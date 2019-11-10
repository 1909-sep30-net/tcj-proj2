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


        [Fact]
        public async Task TestShouldAddAQuestion()
        {
            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.GetAUserAsync(It.IsAny<string>()))
                .Returns(Task.FromResult(new User
                {
                    FirstName = "hi",
                    LastName="bye",
                    Username="Testme",
                    Email="hfsao@gamil.com",
                    Id=3,
                    Phone="678908765789",
                    Password="jkjkjk"

                    

                })); 

            Mock<IForumRepo> _forumrepo = new Mock<IForumRepo>();
            

            _forumrepo.Setup(r => r.AddQuestionAsync(It.IsAny<Question>()));


            Mock<ILogger<ForumController>> logger = new Mock<ILogger<ForumController>>();
            var controller = new ForumController(logger.Object, mockRepo.Object, sentMessage.Object, _forumrepo.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.AddQuestion(new QuestionModel() {Category="Math" }));
            Assert.Equal(201, statusCode.StatusCode);

        }



        [Fact]
        public async Task TestShouldAddAnAnswer()
        {
            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.GetAUserAsync(It.IsAny<string>()))
                .Returns(Task.FromResult(new User
                {
                    FirstName = "hi",
                    LastName = "bye",
                    Username = "Testme",
                    Email = "hfsao@gamil.com",
                    Id = 3,
                    Phone = "678908765789",
                    Password = "jkjkjk"



                }));

            Mock<IForumRepo> _forumrepo = new Mock<IForumRepo>();


            _forumrepo.Setup(r => r.AddAnswerAsync(It.IsAny<Answer>()));


            Mock<ILogger<ForumController>> logger = new Mock<ILogger<ForumController>>();
            var controller = new ForumController(logger.Object, mockRepo.Object, sentMessage.Object, _forumrepo.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.AddAnswer(new AnswerModel() { }));
            Assert.Equal(201, statusCode.StatusCode);

        }

        [Fact]
        public async Task TestShouldEditQuestion()
        {
            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.GetAUserAsync(It.IsAny<string>()))
                .Returns(Task.FromResult(new User
                {
                    FirstName = "hi",
                    LastName = "bye",
                    Username = "Testme",
                    Email = "hfsao@gamil.com",
                    Id = 3,
                    Phone = "678908765789",
                    Password = "jkjkjk"



                }));

            Mock<IForumRepo> _forumrepo = new Mock<IForumRepo>();


            mockRepo.Setup(r => r.ModifyQuestionAsync(It.IsAny<Question>()));


            Mock<ILogger<ForumController>> logger = new Mock<ILogger<ForumController>>();
            var controller = new ForumController(logger.Object, mockRepo.Object, sentMessage.Object, _forumrepo.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.EditQuestion(new QuestionModel() { Category ="Math"}));
            Assert.Equal(202, statusCode.StatusCode);

        }

        [Fact]
        public async Task TestShouldEditAnswer()
        {
            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.GetAUserAsync(It.IsAny<string>()))
                .Returns(Task.FromResult(new User
                {
                    FirstName = "hi",
                    LastName = "bye",
                    Username = "Testme",
                    Email = "hfsao@gamil.com",
                    Id = 3,
                    Phone = "678908765789",
                    Password = "jkjkjk"
                }));

            Mock<IForumRepo> _forumrepo = new Mock<IForumRepo>();


            mockRepo.Setup(r => r.ModifyAnswerAsync(It.IsAny<Answer>()));


            Mock<ILogger<ForumController>> logger = new Mock<ILogger<ForumController>>();
            var controller = new ForumController(logger.Object, mockRepo.Object, sentMessage.Object, _forumrepo.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.EditAnswer(new AnswerModel() {  }));
            Assert.Equal(202, statusCode.StatusCode);

        }

        [Fact]
        public async Task TestShouldDeleteQuestion()
        {
            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.DeleteQuestionAsync(It.IsAny<int>()));
            Mock<IForumRepo> _forumrepo = new Mock<IForumRepo>();
            Mock<ILogger<ForumController>> logger = new Mock<ILogger<ForumController>>();
            var controller = new ForumController(logger.Object, mockRepo.Object, sentMessage.Object, _forumrepo.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.DeleteQuestion(1));
            Assert.Equal(204, statusCode.StatusCode);

        }
        [Fact]
        public async Task TestShouldDeleteAnswer()
        {
            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.DeleteAAnswerAsync(It.IsAny<int>()));
            Mock<IForumRepo> _forumrepo = new Mock<IForumRepo>();
            Mock<ILogger<ForumController>> logger = new Mock<ILogger<ForumController>>();
            var controller = new ForumController(logger.Object, mockRepo.Object, sentMessage.Object, _forumrepo.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.DeleteAnswer(1));
            Assert.Equal(204, statusCode.StatusCode);

        }
    }
}
