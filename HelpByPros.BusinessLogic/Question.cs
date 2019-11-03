using System.Collections.Generic;

namespace HelpByPros.BusinessLogic
{

    public class Question : IQuestion
    {
        /// <summary>
        /// There is a category for a question.
        /// </summary>
        public Category Category { get; set; } = new Category();

        /// <summary>
        /// There is goign to be 1 question in a single instance of Question Class
        /// </summary>
        public string UserQuestion { get; set; }
        /// <summary>
        /// There is a question body for every question. 
        /// </summary>
        public string QuestionBOdy { get; set; }

        /// <summary>
        /// There is going to be mulitple answers for a single questions
        /// </summary>
        public List<Answer> Answer { get; set; } = new List<Answer>();

        /// <summary>
        /// the orginal author of the question 
        /// </summary>
        public IUser Author { get; set; } = new User();

        /// <summary>
        /// track the question if it is already being answered 
        /// </summary>
        public bool Answered { get; set; } = new bool();


        public int Id { get; set; }
    }
}
