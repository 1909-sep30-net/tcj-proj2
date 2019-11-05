using System;
using Xunit;
using HelpByPros.BusinessLogic;
using System.Collections.Generic;

namespace HelpByPros.Test
{
    public class MemberTestBL
    {
        private readonly Member _member = new Member();

        [Fact]
        public void MyQuestion_StoresCorrectly()
        {
            List<Question> myQuestion = new List<Question>();

            _member.MyQuestion = myQuestion;

            Assert.Equal(myQuestion, _member.MyQuestion);
        }

        [Fact]
        public void PointAvailable_StoresCorrectly()
        {
            int pointAvailable = 10;

            _member.PointAvailable = pointAvailable;

            Assert.Equal(pointAvailable, _member.PointAvailable);
        }

        [Fact]
        public void MyAnswers_StoresCorrectly()
        {
            List<Answer> myAnswers = new List<Answer>();

            _member.MyAnswers = myAnswers;

            Assert.Equal(myAnswers, _member.MyAnswers);
        }
    }
}
