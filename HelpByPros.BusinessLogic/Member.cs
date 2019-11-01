using System.Collections.Generic;

namespace HelpByPros.BusinessLogic
{
    public class Member:User
    {
        /// <summary>
        /// These are the question that is posted by this user 
        /// </summary>
        public List<Question> MyQuestion { get; set; } = new List<Question>();
        public int PointAvailable { get; set; }
        /// <summary>
        /// These are the Answers that is posted by this user 
        /// </summary>
        public List<Answer> MyAnswers { get; set; } = new List<Answer>();


    }
}
