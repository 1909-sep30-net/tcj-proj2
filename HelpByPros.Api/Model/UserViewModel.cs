using HelpByPros.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpByPros.Api.Model
{
    public class RegisterViewModel
    {
        private User _user;
        private Member _member;
        private Professional _professonal;
        private Admin _admin;
        public Member RegisterMember
        {
            get { return _member; }
            set
            {
                _member.Email = value.Email;
                _member.FirstName = value.FirstName;
                _member.LastName = value.LastName;
                _member.Username = value.Username;
                _member.Password = value.Password;
                _member.PointAvailable = 0;
                _member.Phone = value.Phone;

            }
        }
        public Professional RegisterProfessionl
        {
            get { return _professonal; }
            set
            {
                _professonal.Email = value.Email;
                _professonal.FirstName = value.FirstName;
                _professonal.LastName = value.LastName;
                _professonal.Username = value.Username;
                _professonal.Password = value.Password;
                _professonal.PointAvailable = 0;
                _professonal.Phone = value.Phone;
                _professonal._category = value._category;// enum stating what you good at 
                _professonal.YearsOfExp = value.YearsOfExp;
                _professonal.Credential = value.Credential;// link to your profile(lindeln) for other to check your trust


            }
        }

        public Admin RegisterAdmin
        {
            get { return _admin; }
            set
            {
                _admin.Email = value.Email;
                _admin.FirstName = value.FirstName;
                _admin.LastName = value.LastName;
                _admin.Username = value.Username;
                _admin.Password = value.Password;
                _admin.Phone = value.Phone;


            }
        }
    }
}
