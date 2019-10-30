using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HelpByPros.BusinessLogic
{
    public class User : IUser
    {
        /// <summary>
        /// firstname
        /// </summary>
        [Required]
        public string FirstName { get; set; }
        /// <summary>
        /// lastname 
        /// </summary>
        public string LastName { get; set; }
        /// <summary>
        /// To notify a question has been raised or answer has been answered
        /// </summary>
        public string Email { get; set; }
        /// <summary>
        /// user name
        /// </summary>
        public string Username { get; set; }
        /// <summary>
        /// password 
        /// </summary>
        public string Password { get; set; }


    }
}
