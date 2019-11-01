using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.BusinessLogic
{
    public class Professional:User
    {
        /// <summary>
        /// Linkeldn info; prefer a link to their profile
        /// </summary>
        public string Crediential { get; set; }
        public List<Question> MyQuestion { get; set; } = new List<Question>();
        public List<Answer> MyAnswers { get; set; } = new List<Answer>();

        public int PointAvailable { get; set; }
        
        public int YearsOfExp { get; set; }
        public Title Title { get; set; }
    }
}
