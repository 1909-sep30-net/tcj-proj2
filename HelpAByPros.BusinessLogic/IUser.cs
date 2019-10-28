using System;
using System.Collections.Generic;
using System.Text;

namespace HelpAByPros.BusinessLogic
{
    interface IUser
    {
        
        string FirstName{ get; set; }
        string LastName { get; set; }
        string Email { get; set; }       

    }
}
