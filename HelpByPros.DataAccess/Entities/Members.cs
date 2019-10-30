using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.DataAccess.Entities
{
    public class Members : Users
    {
        public Users User { get; set; }
        public AccountInfo AccountInfo { get; set; }
    }
}
