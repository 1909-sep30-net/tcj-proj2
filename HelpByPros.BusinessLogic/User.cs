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
        /// phone should be a regex
        /// </summary>
        public int Phone { get; set; }
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
        /// <summary>
        /// adding pictures in the future
        /// </summary>
        public byte[] Profile_Pic { get; set; }

        public int Id { get; set; }

    }
}
