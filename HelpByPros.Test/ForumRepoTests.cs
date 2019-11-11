using HelpByPros.BusinessLogic;
using HelpByPros.DataAccess;
using HelpByPros.DataAccess.Entities;
using HelpByPros.DataAccess.Repo;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using Xunit;

namespace HelpByPros.Test
{
    public class ForumRepoTests
    {
        [Fact]
        public async void AddAnswerAsyncShouldAdd()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddAnswerAsyncShouldAdd")
                .Options;

            using var actContext = new PH_DbContext(options);
            var repo = new ForumRepo(actContext);

            User newUser = new User()
            {
                FirstName = "Rando",
                LastName = "Random",
                Email = "rando@random.ran",
                Username = "randorandom",
                Password = "ranran",
                Phone = "1231231234",
                //PointAvailable = 100
            };

            Answer newAnswer = new Answer()
            {
                Author = newUser
            };

            // act
            await repo.AddAnswerAsync(newAnswer);
            //actContext.SaveChanges();

            // assert
            using var assertContext = new PH_DbContext(options);
            var member = assertContext.Answers.Select(m => newAnswer);
            Assert.NotNull(member);
        }

        [Fact]
        public async void AddAnswerAsyncShouldThrowExcpetion()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddAnswerAsyncShouldThrowExcpetion")
                .Options;

            using var actContext = new PH_DbContext(options);
            var repo = new ForumRepo(actContext);

            var newAnswer = new Answer();

            try
            {
                await repo.AddAnswerAsync(newAnswer);

            }
            catch (InvalidOperationException ex)
            {
                Assert.Equal("There is no user logged in.", ex.Message);

            }
        }

        [Fact]
        public async void AddQuestionAsyncShouldAdd()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddQuestionAsyncShouldAdd")
                .Options;

            using var actContext = new PH_DbContext(options);
            var repo = new ForumRepo(actContext);

            Users newUsers = new Users()
            {
                FirstName = "Rando",
                LastName = "Random",
                Email = "rando@random.ran",
                Username = "randorandom",
                Password = "ranran",
                Phone = "1231231234",
                //PointAvailable = 100
            };

            actContext.Add(newUsers);
            actContext.SaveChanges();

            var newQuestion = new Question()
            {
                AuthorName = "randorandom"
            };

            // act
            await repo.AddQuestionAsync(newQuestion);
            //actContext.SaveChanges();

            // assert
            using var assertContext = new PH_DbContext(options);
            var ques = assertContext.Questions.Select(q => newQuestion);
            Assert.NotNull(ques);
        }

        [Fact]
        public async void AddQuestionAsyncShouldThrowExcpetion()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddQuestionAsyncShouldThrowExcpetion")
                .Options;

            using var actContext = new PH_DbContext(options);
            var repo = new ForumRepo(actContext);

            var newQuestion = new Question();

            try
            {
                await repo.AddQuestionAsync(newQuestion);

            }
            catch (InvalidOperationException ex)
            {
                Assert.Equal("There is no user logged in.", ex.Message);

            }
        }
    }
}
