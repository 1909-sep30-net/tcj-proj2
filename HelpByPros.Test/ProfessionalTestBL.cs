using System;
using Xunit;
using HelpByPros.BusinessLogic;
using System.Collections.Generic;

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
            List<Question> question = new List<Question>();

            _professional.MyQuestion = question;

            Assert.Equal(question, _professional.MyQuestion);
        }

        [Fact]
        public void MyAnswers_StoresCorrectly()
        {
            List<Answer> answer = new List<Answer>();

            _professional.MyAnswers = answer;

            Assert.Equal(answer, _professional.MyAnswers);
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
            Category title = Category.Medical;

            _professional.Category = title.ToString();

            Assert.Equal(title, (Category)Enum.Parse(typeof(Category), _professional.Category, true));
        }

    }
}
