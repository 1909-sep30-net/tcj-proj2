namespace HelpByPros.DataAccess.Entities
{
    public class AccountInfo
    {
        public int Id { get; set; }
        public int PointAvailable { get; set; }
       // public float Money { get; set; }
        public Members Member { get; set; }
        public Professionals Professional { get; set; }

    }
}