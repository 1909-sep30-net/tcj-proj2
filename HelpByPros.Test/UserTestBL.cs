using System;
using Xunit;
using HelpByPros.BusinessLogic;

namespace HelpByPros.Test
{
    public class UserTestBL
    {
        //
        /// 1. test the names // check for nulls, formats, length ..etc. 
        /// 2. test the email  // check for nulls, formats,  length ..etc. 
        /// 3. username & password // check for nulls, formats,  length , the uniqueness of the username 


        // Test each part of the business logic in seperate method. 

        [Fact]
        public void UserNameShouldFomatCorrectly_Test()
        {

        }
        [Fact]

        public void UserEmailShouldFormat_Test()
        {

        }
        [Fact]

        public void UserLogin_Test()
        {

        }



        [Fact]

        public void USerDataCreatedSuccessful_Test()
        {

            //Arrange

            string fname = "John";
            string lname = "Smith";

            string email = "john.smith@gmail.com";

            string login = "johnny";
            string password = "password";


            //Act
            IUser user = new User()
            {
                FirstName = fname,
                LastName = lname,
                Email = email,
                Username = login,
                Password = password
            };

            //Assert
            Assert.Equal(fname, user.FirstName);
            Assert.Equal(lname, user.LastName);
            Assert.Equal(email, user.Email);
            Assert.Equal(login, user.Username);
            Assert.Equal(password, user.Password);

        }

        
        [Theory]
        [ InlineData( "Jane", "Doe", "jane.doe@yahoo.com", "janey", "12345") ] //arrange

        public void CreateMultipleUsers_Test(string value1, string value2, string value3, string value4, string value5)
        {

            //Act

            //We need a constructor so we can simply write this...
            //IUser user = new User(fname, lname, email, login, password);

            //instead of this
            //Act
            IUser user = new User() { FirstName = value1, LastName = value2, Email = value3, Username = value4, Password = value5 };


            //Assert
            Assert.Equal(value1, user.FirstName);
            Assert.Equal(value2, user.LastName);
            Assert.Equal(value3, user.Email);
            Assert.Equal(value4, user.Username);
            Assert.Equal(value5, user.Password);

        }


        ///
        /// <summary>
        /// The following tests if bad user data, specifically blank or null, has been submitted for a User.
        /// </summary>
        ///
        /*
        [Theory]
        [InlineData("Sammy", "Davis Jr.", "sammydjr@ysammy.com", "sammeh", "121239")] //arrange
        [InlineData("Sammy", "", "sammydjr@ysammy.com", "sammeh", "121239")] //arrange
        [InlineData("Sammy", "Davis Jr.", "", "sammeh", "121239")] //arrange
        [InlineData("Sammy", "Davis Jr.", "sammydjr@ysammy.com", "", "121239")] //arrange
        [InlineData("Sammy", "Davis Jr.", "sammydjr@ysammy.com", "sammeh", "")] //arrange


        public void CreateBadUsers_Test(string value1, string value2, string value3, string value4, string value5)
        {
            //arrange

            //Act

            //We need a constructor so we can simply write this...
            //IUser user = new User(fname, lname, email, login, password);

            //instead of this
            //Act
            IUser user = new User() { FirstName = value1, LastName = value2, Email = value3, Username = value4, Password = value5 };


            //Assert
            Assert.NotEqual("", user.FirstName);
            Assert.NotNull(user.FirstName);

            Assert.NotEqual("", user.LastName);
            Assert.NotNull(user.LastName);
            
            Assert.NotEqual("", user.Email);
            Assert.NotNull(user.Email);
            
            Assert.NotEqual("", user.Username);
            Assert.NotNull(user.Username);
            
            Assert.NotEqual("", user.Password);
            Assert.NotNull(user.Password);

        }

        */
    }
}
