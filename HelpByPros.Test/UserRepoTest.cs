
using Microsoft.EntityFrameworkCore;
using Xunit;
using HelpByPros.DataAccess.Entities;
using HelpByPros.DataAccess.Repo;
using HelpByPros.BusinessLogic;
using System.Collections.Generic;
using System.Linq;

namespace HelpByPros.Test
{
    public class UserRepoTest
    {
        
        //[Fact]
        //public async void AddMemberAsyncShouldAdd()
        //{
        //    // arrange
        //    var options = new DbContextOptionsBuilder<PH_DbContext>()
        //        .UseInMemoryDatabase("AddMemberAsyncShouldAdd")
        //        .Options;

        //    var points = 10;
        //    var newMember = new Member { PointAvailable = points};

        //    using var actContext = new PH_DbContext(options);
        //    var repo = new UserRepo(actContext);

        //    // act
        //    await repo.AddMemberAsync(newMember);
        //    actContext.SaveChanges();
            
        //    // assert
        //    using var assertContext = new PH_DbContext(options);
        //    var member = assertContext.Members.First(m => m.AccInfo.PointAvailable == points);
        //    Assert.NotNull(member);
        //}

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

            arrangeContext.Users.Add(new Users { Id = id, FirstName = firstName });
            arrangeContext.SaveChanges();

            using var actContext = new PH_DbContext(options);
            var repo = new UserRepo(actContext);

            // act
            var result = repo.GetAMemberAsync(firstName);

            // assert
            Assert.NotNull(result);
        }

        [Fact]
        public void GetMemberListShouldReturnResult()
        {
            // arrange
            var options = new DbContextOptionsBuilder<PH_DbContext>()
                .UseInMemoryDatabase("GetMemberListShouldReturnResult")
                .Options;

            using var arrangeContext = new PH_DbContext(options);

            var id = 5;

            arrangeContext.Users.Add(new Users { Id = id, FirstName = "Abc" });
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


    }
}
