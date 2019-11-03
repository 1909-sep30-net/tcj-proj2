using System.Collections.Generic;

namespace HelpByPros.DataAccess.Entities
{
    public class Users
    {
        public Users()
        {
            AnsCollection = new HashSet<Answers>();
            QueCollection = new HashSet<Questions>();

            Members = new HashSet<Members>();

            Admins = new HashSet<Admins>();

            Professionals = new HashSet<Professionals>();

        }

        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public byte[] Profile_Pic { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }

        public string Username { get; set; }
        public string Password { get; set; }

        public ICollection<Members> Members {get;set;}
        public ICollection<Admins> Admins { get; set; }
        public ICollection<Professionals> Professionals { get; set; }
        public ICollection<Questions> QueCollection { get; set; }
        public ICollection<Answers> AnsCollection { get; set; }



    }




}
