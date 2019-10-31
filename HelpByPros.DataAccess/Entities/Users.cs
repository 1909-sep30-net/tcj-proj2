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
        public int Phone { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Members> Members {get;set;}
        public ICollection<Admin> Admins { get; set; }
        public ICollection<Professional> Professionals { get; set; }
        public ICollection<Questions> QueCollection { get; set; }
        public ICollection<Answers> AnsCollection { get; set; }



    }




}
