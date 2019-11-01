

namespace HelpByPros.DataAccess.Entities
{
   public  class Professionals
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public int UserID { get; set; }
        public int AccountInfoID { get; set; }

        public AccountInfo AccInfo { get; set; }
        public int ProfessionID { get; set; }

        public Professions Profession { get; set; }
        public int YearsOfExp { get; set; }

    }
}
