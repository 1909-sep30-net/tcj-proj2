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
        /// getting a single member 
        /// </summary>
        /// <returns></returns>
        Task<Member> GetAMemberAsync(string UserName=default,int UserID=0);
        /// <summary>
        /// getting a professional
        /// </summary>
        /// <returns></returns>
        Task<Professional> GetAProfessionalAsync(string UserName=default, int UserID=0);

     
        #endregion




    }
}
