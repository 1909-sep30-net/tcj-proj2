

namespace HelpByPros.BusinessLogic
{
    public interface IUser
    {
         string FirstName{ get; set; }
         string LastName { get; set; }
         string Email { get; set; }

         string Username { get; set; }
         string Password { get; set; }
         int Id { get; set; }

    }
}
