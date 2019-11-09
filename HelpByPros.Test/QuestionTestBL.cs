using System;
using Xunit;
using HelpByPros.BusinessLogic;
using System.Collections.Generic;

namespace HelpByPros.Test
{
    public class QuestionTestBL
    {
        private readonly Question _question = new Question();

        [Fact]
        public void Category_StoresCorrectly()
        {
            string category = "Math";

            _question.Category = category.ToString();

            Assert.Equal(category.ToString(), _question.Category);
        }

        [Fact]
        public void UserQuestion_StoresCorrectly()
        {
            string userQuestion = "Is this is a certain amount of text?";

            _question.UserQuestion = userQuestion;

            Assert.Equal(userQuestion, _question.UserQuestion);
        }

        [Fact]
        public void QuestionBody_StoresCorrectly()
        {
            string questionBody = "This is the question body.";

            _question.QuestionBody = questionBody;

            Assert.Equal(questionBody, _question.QuestionBody);
        }

        [Fact]
        public void Answer_StoresCorrectly()
        {
            List<Answer> answerList = new List<Answer>();

            _question.Answer = answerList;

            Assert.Equal(answerList, _question.Answer);
        }

        [Fact]
        public void Author_StoresCorrectly()
        {
            User author = new User(); ;

            _question.Author = author;

            Assert.Equal(author, _question.Author);
        }

        [Fact]
        public void Answered_StoresCorrectly()
        {
            bool answered = false;

            _question.Answered = answered;

            Assert.Equal(answered, _question.Answered);
        }
    }
}
