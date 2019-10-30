using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.BusinessLogic
{
    public class Answer
    {
        /// <summary>
        /// An answer there is always a single best answer. 
        /// By deffault Best is always set to false.
        /// </summary>        
        public bool  Best { get; set;}
        
        /// <summary>
        ///The answer that a user answered.  
        /// </summary>
        public string AnswerText { get; set; }
        /// <summary>
        /// The author of the answer.
        /// </summary>
        public IUser Author { get; set; } = new User();
        /// <summary>
        /// A way to know how will the question is been answered. 
        /// </summary>
        public int UpVote { get; set; }

        /// <summary>
        /// A way to know how will the question is been answered. 
        /// </summary>
        public int DownVote { get; set; }
        /// <summary>
        /// Citing source of truth  
        /// </summary>
        public int Source { get; set; }

    }
}
