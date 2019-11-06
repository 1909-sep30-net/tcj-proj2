using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace HelpByPros.BusinessLogic
{
    public class Professional : User
    {
        /// <summary>
        /// Linkeldn info; prefer a link to their profile
        /// </summary>
        [Required(ErrorMessage = "Please Enter Credentials")]
        [Display(Name = "Credentials")]
        public string Credential { get; set; }

        /// <summary>
        /// A list for Questions asked.
        /// </summary>        
        public List<Question> MyQuestion { get; set; } = new List<Question>();

        /// <summary>
        /// A List for Answers given.
        /// </summary>        
        public List<Answer> MyAnswers { get; set; } = new List<Answer>();

        /// <summary>
        /// Earned points.
        /// </summary>
        public int PointAvailable { get; set; }

        /// <summary>
        /// Years of Experience in Profession.
        /// </summary>
        [Range(0, int.MaxValue, ErrorMessage = "Please enter valid integer Number")]
        [Required(ErrorMessage = "Enter Years of Experience")]
        public int YearsOfExp { get; set; }

        private Category _category;
        /// <summary>
        /// Professional Title.
        /// </summary>
        [Required(ErrorMessage = "Please Enter a Title")]
        [RegularExpression(@"^[a-zA-Z]+$", ErrorMessage = "Category Must be Letters")]
        public string Category
        {

            get
            {
                return _category.ToString();
            }
            set
            {
                try
                {

                    _category=(Category)Enum.Parse(typeof(Category), value, true);
                }
                catch (InvalidOperationException)
                {
                    throw new InvalidOperationException("There is no such Category.");
                }
            }


        }
        public string Summary { get; set; }
    }
}

    
