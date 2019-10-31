using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.DataAccess.Entities
{
   public  class Professional
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public int UserID { get; set; }
        public int AccountInfoID { get; set; }

        public AccountInfo AccountInfo { get; set; }
        public int ProfessionID { get; set; }

        public Professions Profession { get; set; }

    }
}
