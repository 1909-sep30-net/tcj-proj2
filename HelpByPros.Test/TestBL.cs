using System;
using Xunit;
using HelpByPros.BusinessLogic;

namespace HelpByPros.Test
{
    public class TestBL
    {
        [Fact]

        public void USerDataCreatedSuccessful_Test()
        {

            //Arrange

            string fname = "John";
            string lname = "Smith";
            string phone = "1231231234";
            string email = "john.smith@gmail.com";
            string login = "johnny";
            string password = "password";



            //Act
            IUser user = new User()
            {
                FirstName = fname,
                LastName = lname,
                Phone = phone,
                Email = email,
                Username = login,
                Password = password,
            };

            //Assert
            Assert.Equal(fname, user.FirstName);
            Assert.Equal(lname, user.LastName);
            Assert.Equal(phone, user.Phone);
            Assert.Equal(email, user.Email);
            Assert.Equal(login, user.Username);
            Assert.Equal(password, user.Password);

        }


        [Theory]
        [InlineData("Jane", "Doe", "jane.doe@yahoo.com", "janey", "12345")] //arrange

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
        /// Tests for correct data type.  While not SUPER important
        /// for business logic, should be used for network-traffic.
        /// </summary>
        ///

        /*//must be strongly typed by default, so needless.
        [Theory]
        [InlineData(7, "Davis Jr.", "sammydjr@ysammy.com", "sammeh", "121239")] //arrange
        [InlineData("Sammy", 8, "sammydjr@ysammy.com", "sammeh", "121239")] //arrange
        [InlineData("Sammy", "Davis Jr.", 9, "sammeh", "121239")] //arrange
        [InlineData("Sammy", "Davis Jr.", "sammydjr@ysammy.com", 10, "121239")] //arrange
        [InlineData("Sammy", "Davis Jr.", "sammydjr@ysammy.com", "sammeh", 11)] //arrange
        */

        [Fact]
        public void BusinessLogic_User_TestForValidDataType()
        {
            //assemble

            User labRat = new User() { FirstName = "Sammy", LastName = "Davis", Email = "Junior", Username = "sammeh", Password = "121234" };

            for (int i = 0; i < 7; i++)
            {
                switch (i)
                {
                    case 1:
                        Assert.IsType<string>(labRat.FirstName);
                        break;

                    case 2:
                        Assert.IsType<string>(labRat.LastName);
                        break;

                    case 3:
                        Assert.IsType<string>(labRat.Email);
                        break;

                    case 4:
                        Assert.IsType<string>(labRat.Username);
                        break;

                    case 5:
                        Assert.IsType<string>(labRat.Password);
                        break;

                    default:
                        break;

                }

            }


            //We need a constructor so we can simply write this...
            //IUser user = new User(fname, lname, email, login, password);

            //Act
            /*
            try
            { 
                if(act1.FirstName == null)
                { 
                    throw new NullReferenceException;
                }
                string act1a = act1.FirstName.ToUpper();
            }
            catch(NullReferenceException ex)
            {
                Assert.Throws<NullReferenceException>(() => act1.FirstName.ToUpper());
            }
            */

            //Action act = () => act1.FirstName.ToUpper();

            //Assert.Throws<NullReferenceException>( () => act1.FirstName.ToUpper() );

            //Assert



            /*
            Assert.Equal( ArgumentException, ex );


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
            */
        }

        ///
        //<summary>
        //Test for blank values - > ""
        ///

        [Fact]
        public void BusinessLogic_User_TestForBlankField()
        {

            
        }


    }
}
