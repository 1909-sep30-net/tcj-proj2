using HelpByPros.BusinessLogic;
using Xunit;

namespace HelpByPros.DataAccess
{
    public class AnswerTestBL
    {
        private readonly Answer _answer = new Answer();

        [Fact]
        public void Best_StoresCorrectly()
        {
            bool best = true;

            _answer.Best = best;

            Assert.Equal(best, _answer.Best);
        }

        [Fact]
        public void AnswerText_StoresCorrectly()
        {
            string text = "This is a certain amount of text";

            _answer.AnswerText = text;

            Assert.Equal(text, _answer.AnswerText);
        }

        [Fact]
        public void Author_StoresCorrectly()
        {
            IUser user = new User();

            _answer.Author = user;

            Assert.Equal(user, _answer.Author);
        }

        [Fact]
        public void UpVote_StoresCorrectly()
        {
            int upVote = 10;

            _answer.UpVote = upVote;

            Assert.Equal(upVote, _answer.UpVote);
        }

        [Fact]
        public void DownVote_StoresCorrectly()
        {
            int downVote = 5;

            _answer.DownVote = downVote;

            Assert.Equal(downVote, _answer.DownVote);
        }

        [Fact]
        public void Source_StoresCorrectly()
        {
            string source = "New York Times";

            _answer.Source = source;

            Assert.Equal(source, _answer.Source);
        }

        [Fact]
        public void AnsQuestionId_StoresCorrectly()
        {
            int ansQuestionId = 143;

            _answer.AnsQuestionID = ansQuestionId;

            Assert.Equal(ansQuestionId, _answer.AnsQuestionID);
        }
    }
}
