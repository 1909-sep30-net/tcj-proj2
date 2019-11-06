using System.Collections.Generic;

namespace HelpByPros.DataAccess.Entities
{

    public class Questions
    {
        public Questions()
        {
            AnsCollection = new HashSet<Answers>();
        }

        public int Id { get; set; }
        public string Category { get; set; }
        public string UserQuestion { get; set; }
        public string QuestionBody { get; set; }
        public int UsersID { get; set; }
        public Users Users { get; set; }
        public bool Answered { get; set; }
        public ICollection<Answers> AnsCollection { get; set; }
    }
}
