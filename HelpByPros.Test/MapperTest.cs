using HelpByPros.BusinessLogic;
using HelpByPros.DataAccess;
using HelpByPros.DataAccess.Entities;
using Xunit;

namespace HelpByPros.Test
{
    public class MapperTest
    {
        string firstName = "rando";
        string lastName = "random";
        string phone = "1231231234";
        string email = "rando@ran.dom";
        string username = "randorandom";
        string password = "ranran";

        /// <summary>
        /// User MapUser should Map Users to User
        /// </summary>
        [Fact]
        public void UserMapUserShouldMapUsersToUser()
        {
            Users newUsers = new Users()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Username = username,
                Password = password
            };

            User testUser = Mapper.MapUser(newUsers);

            Assert.Equal(firstName, testUser.FirstName);
        }

        /// <summary>
        /// Users MapUser should Map User to Users
        /// </summary>
        [Fact]
        public void UsersMapUserShouldMapToUsers()
        {
            User newUser = new User()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Username = username,
                Password = password
            };

            Users testUser = Mapper.MapUser(newUser);

            Assert.Equal(firstName, testUser.FirstName);
        }

        /// <summary>
        /// Member MapMember should map Members to Member
        /// </summary>
        [Fact]
        public void MemberMapMemberShouldMapMemberstoMember()
        {
            Users newUsers = new Users()
            {
                FirstName = firstName,
                LastName = lastName,
                Phone = phone,
                Username = username,
                Password = password
            };

            AccountInfo acctInfo = new AccountInfo();

            Members newMembers = new Members()
            {
                User = newUsers,
                AccInfo = acctInfo
            };

            Member testMember = Mapper.MapMember(newMembers);

            Assert.Equal(newUsers.FirstName, testMember.FirstName);
        }
    }
}
