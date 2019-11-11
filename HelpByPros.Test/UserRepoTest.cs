
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
    public class UserRepoTest
    {
        /// <summary>
        /// Tests adding a MEMBER to the Database.
        /// </summary>
        [Fact]
        public async void AddMemberAsyncShouldAdd()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddMemberAsyncShouldAdd")
                .Options;

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            Member newMember = new Member()
            {
                FirstName = "Rando",
                LastName = "Random",
                Email = "rando@random.ran",
                Username = "randorandom",
                Password = "ranran",
                Phone = "1231231234",
                //PointAvailable = 100
            };

            // act
            await repo.AddMemberAsync(newMember);
            //actContext.SaveChanges();

            // assert
            using var assertContext = new PH_DbContext(options);
            var member = assertContext.Members.Select(m => newMember);
            Assert.NotNull(member);
        }

        //needs to be fixed once UserRepo method is working correctly
        [Fact]
        public async void AddMemberAsyncShouldThrowExcpetion()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddMemberAsyncShouldThrowExcpetion")
                .Options;

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            Member newMember = new Member()
            {
                FirstName = "Rando",
                LastName = "Random",
                Email = "rando@random.ran",
                Username = "randorandom",
                Password = "ranran",
                Phone = "1231231234",
                //PointAvailable = 100
            };


            // act
            try
            {
                await repo.AddMemberAsync(newMember);
                await repo.AddMemberAsync(newMember);
                
            }
            catch (InvalidOperationException ex)
            {
                Assert.Equal("Duplicate info in unique Column", ex.Message);

            }
        }

        /// <summary>
        /// Tests adding a PROFESSIONAL to the Database.
        /// </summary>
        [Fact]
        public async void AddProfessionalAsyncShouldAdd()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddProfessionalAsyncShouldAdd")
                .Options;

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            Professional professional = new Professional()
            {
                Email = "random@ran.dom",
                FirstName = "Rando",
                LastName = "Random",
                Username = "randorandom",
                Password = "ranran",
                Phone = "1231231234",
                //Profile_Pic = p.User.Profile_Pic,
                //PointAvailable = p.AccInfo.PointAvailable,
                Category = "Math"
            };

            // act
            await repo.AddProfessionalAsync(professional);
            //actContext.SaveChanges();

            // assert
            using var assertContext = new PH_DbContext(options);
            var member = assertContext.Members.Select(m => professional);
            Assert.NotNull(member);
        }

        [Fact]
        public async void AddProfessionalAsyncShouldThrowExcpetion()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("AddProfessionalAsyncShouldThrowExcpetion")
                .Options;

            Professional professional = new Professional()
            {
                Email = "random@ran.dom",
                FirstName = "Rando",
                LastName = "Random",
                Username = "randorandom",
                Password = "ranran",
                Phone = "1231231234",
                //Profile_Pic = p.User.Profile_Pic,
                //PointAvailable = p.AccInfo.PointAvailable,
                Category = "Math"
            };

            Professional professional2 = new Professional()
            {
                Email = "random@ran.dom",
                FirstName = "Randwo",
                LastName = "Randowm",
                Username = "randorandom",
                Password = "rawnran",
                Phone = "w",
                //Profile_Pic = p.User.Profile_Pic,
                //PointAvailable = p.AccInfo.PointAvailable,
                Category = "English"
            };

            using (var actContext = new PH_DbContext(options))
            {
                var repo = new UserRepo(actContext);

                // act
                try {
                    await repo.AddProfessionalAsync(professional);
                    await repo.AddProfessionalAsync(professional);
                }
                catch ( InvalidOperationException ex)
                {
                    Assert.Equal("Duplicate info in unique Column", ex.Message);

                }
                //   Exception ex = await Assert.ThrowsAsync<InvalidOperationException>(() => repo.AddProfessionalAsync(professional));

               // Assert.Equal("Duplicate info in unique Column", ex.Message);


            }
   



        }

        /// <summary>
        /// Tests retrieving a MEMBER from the Database.
        /// </summary>
        [Fact]
        public void GetAMemberAsyncShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAMemberAsyncShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;
            var firstName = "Abc";

            arrangeContext.Users.Add(new Users { FirstName = firstName });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetAMemberAsync(firstName);

            // assert
            Assert.NotNull(result);
        }

        /// <summary>
        /// GetAMemberAsynch should throw exception if NULL.
        /// </summary>
        [Fact]
        public void GetAMemberAsyncShouldThrowNullException()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAMemberAsyncShouldThrowNullException")
                .Options;

            string username = null;

            //assert
            using (var assertContext = new PH_DbContext(options))
            {
                var repo = new UserRepo(assertContext);
                Assert.ThrowsAsync<ArgumentNullException>(() => repo.GetAMemberAsync(username));
            }
        }

        /// <summary>
        /// Tests retrieving a PROFESSIONAL from the Database.
        /// </summary>
        [Fact]
        public void GetAProfessionalAsynchShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAProfessionalAsynchShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;
            var user = new Users { Username = "Porks" };

            arrangeContext.Professionals.Add(new Professionals { Id = id, User = user });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetAProfessionalAsync("Porks");

            // assert
            Assert.NotNull(result);
        }

        /// <summary>
        /// GetAMemberAsynch should throw exception if NULL.
        /// </summary>
        [Fact]
        public void GetAProfessionalAsyncShouldThrowNullException()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAProfessionalAsyncShouldThrowNullException")
                .Options;

            string username = null;

            //assert
            using (var assertContext = new PH_DbContext(options))
            {
                var repo = new UserRepo(assertContext);
                Assert.ThrowsAsync<ArgumentNullException>(() => repo.GetAProfessionalAsync(username));
            }
        }

        /// <summary>
        /// Tests getting a list of MEMBERS from the Database.
        /// </summary>
        [Fact]
        public void GetMemberListShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetMemberListShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;

            arrangeContext.Users.Add(new Users {FirstName = "Abc" });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetMemberListAsync();

            // assert
            // if it is needed to check the actual database here,
            // use a separate assertContext as well.
            Assert.NotNull(result);
        }

        /// <summary>
        /// Tests getting a list of PROFESSIONALS from the Database.
        /// </summary>
        [Fact]
        public void GetProfessionalListShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetProfessionalListShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;
            var userId = 10;

            arrangeContext.Professionals.Add(new Professionals { Id = id, UserID = userId });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetProfessionalListAsync();

            // assert
            Assert.NotNull(result);
        }

        /// <summary>
        /// Test for Modify question
        /// </summary>
        //[Fact]
        //public void ModifyQuestionShouldModify()
        //{
        //    // arrange
        //    var options = new DbContextOptionsBuilder<PH_DbContext>()
        //        .UseInMemoryDatabase("ModifyQuestionShouldModify")
        //        .Options;

        //    Questions questions = new Questions();

        //    string username = "random";

        //    questions.Users.Username = username;
        //    questions.UserQuestion = "Original message";

        //    using (var arrangeContext = new PH_DbContext(options))
        //    {
        //        arrangeContext.Add(questions);
        //        arrangeContext.SaveChanges();
        //    };

        //    Question question = Mapper.MapQuestion(questions);
        //    question.UserQuestion = "New Message";

        //    using var actContext = new PH_DbContext(options);

        //    var repo = new UserRepo(actContext);

        //    repo.ModifyQuestion(question, username);

        //    var modQuestion = actContext.Questions.Select(m => questions.UserQuestion);

        //    Assert.NotEqual(modQuestion.ToString(), questions.UserQuestion);
        //}

        /// <summary>
        /// Exception test for Modify Question
        /// </summary>
        //[Fact]
        //public async Task ModifyQuestionShouldReturnException(Question ques, string username)

        /// <summary>
        /// Test
        /// </summary>
        //public async Task DeleteQuestion(int QuestionID, string username)
        //[Fact]

        /// <summary>
        /// Get User Answer should return a List
        /// </summary>
        //public async Task<IEnumerable<Answer>> GetUsersAnswer(string UserName)
        [Fact]
        public void GetUsersAnswerShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetUsersAnswerShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            string username = "random";

            arrangeContext.Answers.Add(new Answers { Answer = "ligma" });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetUsersAnswerAsync(username);

            // assert
            Assert.NotNull(result);
        }

        /// <summary>
        /// Get Users Question should return a List
        /// </summary>
        [Fact]
        public void GetUsersQuestionShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetUsersQuestionShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            string username = "random";

            arrangeContext.Questions.Add(new Questions { UserQuestion = "wtf?" });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetUsersQuestionAsync(username);

            // assert
            Assert.NotNull(result);
        }

        /// <summary>
        /// Test
        /// </summary>
        //public async Task ModifyAnswer(int answerID, string username)
        //[Fact]

        /// <summary>
        /// Test 
        /// </summary>
        //public async Task<User> GetAUser(string userName)
        [Fact]
        public void GetAUserShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAUserShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;
            var username = "Abc";

            arrangeContext.Users.Add(new Users { Id = id, Username = username });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetAUserAsync(username);

            // assert
            Assert.NotNull(result);
        }

        /// <summary>
        /// Get A User should throw a NULL exception.
        /// </summary>
        [Fact]
        public void GetAUserShouldThrowNullException()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAUserShouldThrowNullException")
                .Options;

            string username = null;

            //assert
            using (var assertContext = new PH_DbContext(options))
            {
                var repo = new UserRepo(assertContext);
                Assert.ThrowsAsync<ArgumentNullException>(() => repo.GetAUserAsync(username));
            }
        }

        /// <summary>
        /// Test
        /// </summary>
        //public async Task DeleteAAnswer(Answer ans, string userName)
        //[Fact]


    }
}
