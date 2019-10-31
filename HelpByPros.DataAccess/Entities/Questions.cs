using System.Collections.Generic;

namespace HelpByPros.DataAccess.Entities
{

    public class Questions
    {
        public int Id;
        public int CategoryID { get; set; }

        public Categorys Category { get; set; }
        public string UserQuestion { get; set; }
        public int UsersID { get; set; }

        public Users Users { get; set; }
        public ICollection<Answers> AnsCollection { get; set; }
    }
}
