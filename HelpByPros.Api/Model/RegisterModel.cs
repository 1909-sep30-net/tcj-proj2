using HelpByPros.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpByPros.Api.Model
{
    public class RegisterModel
    {
        
        public string Email { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Phone { get; set; }
        public bool IsProfessional { get; set; }
        public string Category { get; set; }
        public int YearsOfExp { get; set; }
        public string Credential { get; set; }
        public string Summary { get; set; }

        public Admin RegisterAdmin()
        {
            return new Admin
            {
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                Username = Username,
                Password = Password,
                Phone = Phone
            };
        }


        public Member RegisterMember()
        {
            return new Member
            {
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                Username = Username,
                Password = Password,
                PointAvailable = 0,
                Phone = Phone
            };
        }

        public Professional RegisterProfessional()
        {
            return new Professional
            {
                Email = Email,
                FirstName = FirstName,
                LastName = LastName,
                Username = Username,
                Password = Password,
                PointAvailable = 0,
                Phone = Phone,

            Category = Category,
            YearsOfExp = YearsOfExp,
            Credential = Credential,// link to your profile(lindeln) for other to check your trust
            Summary = Summary
             };
        }

    }
}
