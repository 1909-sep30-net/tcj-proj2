using System;
﻿using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;


namespace HelpByPros.BusinessLogic
{

    public class Question : IQuestion
    {
        /// <summary>

        /// There is a category for a question.
        /// </summary>        
        private Category _categ = new Category();

        public string Category
        {

            get
            {
                return _categ.ToString();
            }
            set
            {
                try
                {

                    _categ = (Category)Enum.Parse(typeof(Category), value, true);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidOperationException("There is no such Category.");
                }
            }


        }


        /// <summary>
        /// There is going to be 1 question in a single instance of Question Class
        /// </summary>
        [Required(ErrorMessage = "Question Title is Required")]
        [StringLength(100, MinimumLength = 10, ErrorMessage = "Question title must be between 10 and 100 characters")]
        public string UserQuestion { get; set; }
        /// <summary>
        /// There is a question body for every question. 
        /// </summary>
        [Required(ErrorMessage = "Question is Required")]
        [StringLength(10000, MinimumLength = 10, ErrorMessage = "Question must be between 10 and 10000 characters")]
        public string QuestionBody { get; set; }

        /// <summary>
        /// There can be mulitple answers to a single question.
        /// </summary>
        public List<Answer> Answer { get; set; } = new List<Answer>();

        /// <summary>
        /// the orginal author of the question 
        /// </summary>
        public User Author { get; set; } = new User();
    
        /// <summary>
        /// Bool for marking whether or not a Question has an Answer. 
        /// </summary>
        public bool Answered { get; set; } = new bool();    

        public int Id { get; set; }
        public string AuthorName { get; set; }
    }
}
