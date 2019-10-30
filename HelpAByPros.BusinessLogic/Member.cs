using System;
using System.Collections.Generic;

namespace HelpAByPros.BusinessLogic
{
    public class Member:User
    {

        public Question Question { get; set; } = new Question();
        public Dictionary<Question, List<Answer>> Answer { get; set; } = new Dictionary<Question, List<Answer>>();
    }
}
