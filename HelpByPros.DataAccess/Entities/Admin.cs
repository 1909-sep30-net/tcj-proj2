﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.DataAccess.Entities
{
    public class Admin
    {
        public int Id { get; set; }
        public int UsersID { get; set; }

        public Users User { get; set; }
    }
}
