using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.DataAccess.Entities
{
    public class Members 
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public int UsersID { get; set; }
        public int AccountInfoID { get; set; }
        public AccountInfo AccountInfo { get; set; }
    }
}
