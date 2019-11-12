using HelpByPros.Api.Controllers;
using HelpByPros.Api.Model;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using Microsoft.Extensions.Logging;
using Moq;
using System.Threading.Tasks;
using Xunit;
using Microsoft.AspNetCore.Mvc;

namespace HelpByPros.Test
{
    public class UserControllerTest
    {
        Mock<IUserRepo> userRepo = new Mock<IUserRepo>();
        Mock<ISentMessage> sentMessage = new Mock<ISentMessage>();
        Mock<IForumRepo> forumrepo = new Mock<IForumRepo>();

        [Fact]
        public async Task TestShouldReturnCorrectRoute()
        {

            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.AddMemberAsync(It.IsAny<Member>()));
            Mock<ILogger<UserController>> logger = new Mock<ILogger<UserController>>();
            var controller = new UserController(logger.Object,mockRepo.Object,sentMessage.Object);

            var statusCode = Assert.IsType<OkResult>(await controller.CreateUser(new RegisterModel() { }));
            Assert.Equal(200, statusCode.StatusCode);
        }

        [Fact]
        public async Task ShouldBeableToEditAnyUser()
        {

            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.ModifyMemberInfoAsync(It.IsAny<Member>()));
            Mock<ILogger<UserController>> logger = new Mock<ILogger<UserController>>();
            var controller = new UserController(logger.Object, mockRepo.Object, sentMessage.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.EditUsers(new RegisterModel() { }));
            Assert.Equal(202, statusCode.StatusCode);

        }

        [Fact]
        public async Task ShouldBeableToUpVoteAnAnswer()
        {

            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.ModifyAnswerUpVotes(30, 3));
            Mock<ILogger<UserController>> logger = new Mock<ILogger<UserController>>();
            var controller = new UserController(logger.Object, mockRepo.Object, sentMessage.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.UpVoteAnswer(30,3));
            Assert.Equal(202, statusCode.StatusCode);

        }

        [Fact]
        public async Task ShouldBeableToDownVoteAnAnswer()
        {

            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.ModifyAnswerDownVotes(30, 3));
            Mock<ILogger<UserController>> logger = new Mock<ILogger<UserController>>();
            var controller = new UserController(logger.Object, mockRepo.Object, sentMessage.Object);

            var statusCode = Assert.IsType<StatusCodeResult>(await controller.DownVoteAnswer(30, 3));
            Assert.Equal(202, statusCode.StatusCode);

        }

        [Fact]
        public async Task GetShouldReturnAMemberModel()
        {


            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.GetAMemberAsync(It.IsAny<string>())).Returns( Task.FromResult(new Member {

            FirstName = "FirstName",
            LastName = "LastName",
            Phone = "Phone",
            Username = "Username",
            Email= "you@yahoo.com"


        } )) ;
            Mock<ILogger<UserController>> logger = new Mock<ILogger<UserController>>();
            var controller = new UserController(logger.Object, mockRepo.Object, sentMessage.Object);

            var model = Assert.IsType<RegisterModel>(await controller.Get("Username"));
            Assert.IsType<RegisterModel>( model);

        }
        [Fact]
        public async Task GetShouldReturnAProfessonalModel()
        {


            var mockRepo = new Mock<IUserRepo>();
            mockRepo.Setup(r => r.GetAProfessionalAsync(It.IsAny<string>())).Returns(Task.FromResult(new Professional
            {

                FirstName = "FirstName",
                LastName = "LastName",
                Phone = "Phone",
                Username = "Username",
                Email = "you@yahoo.com",
                Summary = "prof.Summary",
                YearsOfExp = 4,
                Credential = "prof.Credential",
                Category = "Math"



        }));
            Mock<ILogger<UserController>> logger = new Mock<ILogger<UserController>>();
            var controller = new UserController(logger.Object, mockRepo.Object, sentMessage.Object);

            var model = Assert.IsType<RegisterModel>(await controller.Get("Username"));
            Assert.IsType<RegisterModel>(model);

        }


    }
}
