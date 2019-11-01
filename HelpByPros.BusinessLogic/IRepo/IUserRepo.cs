using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpByPros.BusinessLogic.IRepo
{
    public interface IUserRepo
    {

        #region Adding information to db
        /// <summary>
        /// Add a Member to the DB
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        Task AddMemberAsync(Member m);

        /// <summary>
        /// Add a Professional to the DB
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        Task AddProfessionalAsync(Professional p);

        /// <summary>
        /// Add an Admin to the db
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        Task AddAdminAsync(Admin a);

        #endregion


        #region Getting a List of Info
        /// <summary>
        /// getting a list of Members
        /// </summary>
        /// <param name="user"></param>
        /// <returns></returns>

        Task<IEnumerable <Member>> GetMemberListAsync();
        /// <summary>
        /// getting a list of professional 
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable <Professional>> GetProfessionalListAsync();
        /// <summary>
        /// getting a list admin
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Admin>> GetAdminListAsync();

        /// <summary>
        /// getting a single member 
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Member> GetAMemberAsync(int id);
        /// <summary>
        /// getting a professional
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Member> GetAProfessionalAsync(int id);

        /// <summary>
        /// getting a admin
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        Task<Member> GetAAdminAsync(int id);
        #endregion




    }
}
