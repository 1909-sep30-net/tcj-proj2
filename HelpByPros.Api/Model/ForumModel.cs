using HelpByPros.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpByPros.Api.Model
{
    public class ForumModel
    {
        public Question Question { get; set; }
        public List<Answer> Answers { get; set; }

    }
}
