using System;
using Xunit;
using HelpByPros.BusinessLogic;

namespace HelpByPros.Test
{
    public class ProfessionalTestBL
    {
        private readonly Professional _professional = new Professional();

        [Fact]
        public void Credential_StoresCorrectly()
        {
            string credential = "credential";

            _professional.Credential = credential;

            Assert.Equal(credential, _professional.Credential);
           
        }

        [Fact]
        public void MyQuestion_StoresCorrectly()
        {

        }

        [Fact]
        public void MyAnswers_StoresCorrectly()
        {

        }

        [Fact]
        public void PointAvailable_StoresCorrectly()
        {
            int pointsAvailable = 100;

            _professional.PointAvailable = pointsAvailable;

            Assert.Equal(pointsAvailable, _professional.PointAvailable);

        }

        [Fact]
        public void YearsOfExperience_StoresCorrectly()
        {
            int yearsOfExperience    = 10;

            _professional.YearsOfExp = yearsOfExperience;

            Assert.Equal(yearsOfExperience, _professional.YearsOfExp);

        }

        [Fact]
        public void Title_StoresCorrectly()
        {

        }
    }
}
