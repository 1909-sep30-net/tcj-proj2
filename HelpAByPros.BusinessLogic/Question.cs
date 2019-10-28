using System;
using System.Collections.Generic;
using System.Text;

namespace HelpAByPros.BusinessLogic
{
    enum Category
    {
        Math = 1,
        ComputerScience = 2,
        Construction = 3,
        English = 4

    }
    class Question
    {    

        public string Category { get; set; }

        public string Answer { get; set; }
    }
}
