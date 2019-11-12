using HelpByPros.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpByPros.Api.Model
{
   public class QuestionModel
    {
        
        public string Category { get; set; }
        public string UserQuestion { get; set; }
        public string QuestionBody { get; set; }
        public string Username { get; set; }
        public int QuestionID { get; set; }


        public QuestionModel MapToQuestion(Question q)
        {
            this.Category = q.Category;
            this.QuestionBody = q.QuestionBody;
            this.UserQuestion = q.UserQuestion;
            this.Username = q.AuthorName;
            this.QuestionID = q.Id;
            return this;
        }



    }
}
