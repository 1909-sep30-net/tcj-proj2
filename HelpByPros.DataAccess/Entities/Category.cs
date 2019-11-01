using HelpByPros.BusinessLogic;


namespace HelpByPros.DataAccess.Entities
{

    public class Categorys
    {
        public int Id { get; set; }
        public Category Category { get; set; }

        public Questions Question { get; set; }
    }
}
