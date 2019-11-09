
using Microsoft.EntityFrameworkCore;
using Xunit;
using HelpByPros.DataAccess.Entities;
using HelpByPros.DataAccess.Repo;

namespace HelpByPros.Test
{
    public class UserRepoTest
    {
        [Fact]
        public void GetAMemberAsyncShouldReturnResult()
        {
            // based on nick's restaurant reviews code (nick project 1)
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
            // if it is needed to check the actual database here,
            // use a separate assertContext as well.
            Assert.NotNull(result);
        }
        [Fact]
        public void GetMemberListShouldReturnResult()
        {
            // based on nick's restaurant reviews code (nick project 1)
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
    }
}
