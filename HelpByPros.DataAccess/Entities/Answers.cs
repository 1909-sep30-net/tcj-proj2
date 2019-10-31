﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.DataAccess.Entities
{
    public class Answers
    {
        public int Id { get; set; }
        public int QuestionID { get; set; }
        public Questions Question { get; set; }
        public int UpVote { get; set; }
        public int DownVote { get; set; }
        public int UserID { get; set; }

        public Users User { get; set; }
        public string Answer { get; set; }
    }
}