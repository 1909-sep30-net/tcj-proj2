using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HelpAByPros.BusinessLogic
{
    public class User : IUser, IPayment
    {
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string AccessLevel { get; set = User; }

        public void Payment(int points)
        {
            
        }
    }
}
