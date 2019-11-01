

namespace HelpByPros.DataAccess.Entities
{
    public class Members 
    {
        public int Id { get; set; }
        public Users User { get; set; }
        public int UserID { get; set; }
        public int AccountInfoID { get; set; }
        public AccountInfo AccInfo { get; set; }
    }
}
