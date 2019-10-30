using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.DataAccess.Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Profile_Pic { get; set; }

        public ContactInfo ContactInfo { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }


    }




}
