using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.DataAccess.Entities
{
   public  class Professional: Users
    {
        public Users User { get; set; }
        public AccountInfo AccountInfo { get; set; }
        public Professions Profession { get; set; }

    }
}
