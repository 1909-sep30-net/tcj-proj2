using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace HelpAByPros.BusinessLogic
{
    public class Admin:User
    {
        [Required]
        public string AccessLevel { get; set = Admin; }

        }
}
