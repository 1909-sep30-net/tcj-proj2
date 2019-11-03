

using System.ComponentModel.DataAnnotations;

namespace HelpByPros.BusinessLogic
{
    public class Answer
    {
        public int ID { get; set; }

        /// <summary>
        /// One answer will have status as Best answer. 
        /// By default Best is always set to false.
        /// </summary>
        public bool Best { get; set; }

        /// <summary>
        ///The text of a user's answer.
        ///Answer must be at least 15 characters to avoid one word answers or the like.
        /// </summary>
        [Required(ErrorMessage = "Answer Field is Required.")]
        [Display(Name = "Answer")]
        [StringLength(10000, MinimumLength = 15, ErrorMessage = "Response Must be at Least 15 Characters.")]
        public string AnswerText { get; set; }

        /// <summary>
        /// The author of the answer.
        /// </summary>
        public IUser Author { get; set; } = new User();

        /// <summary>
        /// Positive votes for how well the question is being answered. 
        /// </summary>
        public int UpVote { get; set; }

        /// <summary>
        /// Negative votes for how well the question is being answered.
        /// </summary>
        public int DownVote { get; set; }

        /// <summary>
        /// Citing source of truth  
        /// </summary>
        public string Source { get; set; }

        /// <summary>
        /// ????
        /// </summary>
        public int AnsQuestionID{get;set;}

    }
}
