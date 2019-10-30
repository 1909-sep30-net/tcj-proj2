using System;
using System.Collections.Generic;
using System.Text;

namespace HelpAByPros.BusinessLogic
{
    public enum Category
    {
        Math = 1,
        ComputerScience = 2,
        Construction = 3,
        English = 4

    }
    public class Question
    {
        /// <summary>
        /// There is a category for a question.
        /// </summary>
        public Category Category { get; set; } = new Category();
        
        /// <summary>
        /// There is goign to be 1 question in a single instance of Question Class
        /// </summary>
        public string Quest { get; set; }
        
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

       

    }
}
