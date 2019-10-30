using System;
using System.Collections.Generic;

namespace HelpByPros.BusinessLogic
{
    public class Member:User
    {

        public List<Question> Question { get; set; } = new List<Question>();
        public int PointAvailable { get; set; }


    }
}
