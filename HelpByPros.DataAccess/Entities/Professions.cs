using HelpByPros.BusinessLogic;


namespace HelpByPros.DataAccess.Entities
{


    public class Professions
    {
        public int Id { get; set; }
        public Title Title { get; set; }
        /// <summary>
        /// short desc of what you do. 
        /// </summary>
        public string Summary { get; set; }
        public int YearsOfExperience { get; set; }
        public Professionals Professional { get; set; }
    }
}
