using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpByPros.Api.Model
{
    public class AnswerModel
    {
        public int QuestionID { get; set; }
        public string Username { get; set; }
        public string AnswerBody { get; set; }
        public string Source { get; set; }

        public int Upvote { get; set; }
        public int DownVote { get; set; }
        public int AnswerId { get; set; }
        public Boolean BestAnswer { get; set; }

    }
}
