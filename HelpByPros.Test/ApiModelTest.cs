using HelpByPros.Api.Model;
using Xunit;
using HelpByPros.BusinessLogic;



namespace HelpByPros.Test
{
   public class ApiModelTest
    {
        [Fact]
        public void UserModelShouldMapTtoUser()
        {/*
            public string Email { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string Username { get; set; }
            public string Password { get; set; }
            public string Phone { get; set; }
            public bool IsProfessional { get; set; }
            public string Category { get; set; }
            public int YearsOfExp { get; set; }
            public string Credential { get; set; }
            public string Summary { get; set; }*/



            //ARRANGE 
            var prof = new Professional();
            prof.FirstName = "nan";
            prof.Email = "sca@gmail.com";
            prof.Summary = "i am not good";
            prof.Credential = "link";
            prof.Category = "Math";
            prof.Username = "username";
            prof.YearsOfExp = 30;
            prof.Phone = "919234922";
            prof.LastName = "lastname";


            //Act
            var model = new RegisterModel();
            model.IsProfessional = true;
            model.FirstName = prof.FirstName;
            model.LastName = prof.LastName;
            model.Phone = prof.Phone;
            model.Summary = prof.Summary;
            model.YearsOfExp = prof.YearsOfExp;
            model.Username = prof.Username;
            model.Credential = prof.Credential;
            model.Category = prof.Category;
            model.Email = prof.Email;

            Assert.Equal(prof.Email, model.RegisterProfessional().Email);
            Assert.Equal(prof.FirstName, model.RegisterProfessional().FirstName);
            Assert.Equal(prof.Username, model.RegisterProfessional().Username);
            Assert.Equal(prof.Credential, model.RegisterProfessional().Credential);
            Assert.Equal(prof.Phone, model.RegisterProfessional().Phone);




        }


    }
}
