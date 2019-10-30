using System.Collections.Generic;

namespace HelpByPros.DataAccess.Entities
{

    public class Questions
    {
        public int Id;
        public Categorys Category { get; set; }
        public string UserQuestion { get; set; }
        public Users Users { get; set; }
        public ICollection<Answers> AnsCollection { get; set; }
       
    }
}
