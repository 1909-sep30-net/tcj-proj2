using Microsoft.EntityFrameworkCore;
using Xunit;
using HelpByPros.DataAccess.Entities;
using HelpByPros.DataAccess.Repo;
using HelpByPros.BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace HelpByPros.Test
{
    public class AdminRepoTest
    {
        //public async Task AddAdminAsync(Admin a)

        //public Task DeleteAccountAsync(string UserName = null, int UserID = 0)

        [Fact]
        public void GetAAdminAsyncShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAAdminAsyncShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;
            var UserId = 10;
            var newUser = new Users { Username = "dude" };

            arrangeContext.Admin.Add(new Admins { Id = id, UsersID = UserId, User = newUser });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new AdminRepo(actContext);

            // act
            var result = repo.GetAAdminAsync("dude", UserId);

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetAdminListAsyncShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetAdminListAsyncShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;
            var UserId = 10;
            var newUser = new Users { Username = "dude" };

            arrangeContext.Admin.Add(new Admins { Id = id, UsersID = UserId, User = newUser });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new AdminRepo(actContext);

            // act
            var result = repo.GetAdminListAsync();

            // assert
            Assert.NotNull(result);
        }
    }
}
