using System.Collections.Generic;

namespace HelpByPros.BusinessLogic
{
    public interface IQuestion
    {
        List<Answer> Answer { get; set; }
        bool Answered { get; set; }
        string Category { get; set; }
        string UserQuestion { get; set; }
        string AuthorName { get; set; }
    }
}