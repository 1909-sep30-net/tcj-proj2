﻿using HelpByPros.Api.Controllers;
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
    public class ControllerTest
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

            var statusCode = Assert.IsType<CreatedAtRouteResult>(await controller.CreateUser(new RegisterModel() { }));
            Assert.Equal(201, statusCode.StatusCode);
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

    }
}
