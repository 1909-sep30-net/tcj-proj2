using System.Collections.Generic;

namespace HelpByPros.BusinessLogic
{
    public class Member:User
    {
        /// <summary>
        /// List of questions posted by this user.
        /// </summary>
        public List<Question> MyQuestion { get; set; } = new List<Question>();

        /// <summary>
        /// Points available to this user.
        /// </summary>
        public int PointAvailable { get; set; }

        /// <summary>
        /// List of answers posted by this user.
        /// </summary>
        public List<Answer> MyAnswers { get; set; } = new List<Answer>();


    }
}
