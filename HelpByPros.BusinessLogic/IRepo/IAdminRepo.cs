using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HelpByPros.BusinessLogic.IRepo
{
    /// <summary>
    /// power to add admin 
    /// </summary>
    public interface IAdminRepo
    {
        /// <summary>
        /// Add an Admin to the db
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        Task AddAdminAsync(Admin a);

        /// <summary>
        /// getting a admin
        /// </summary>
        /// <returns></returns>
        Task<Admin> GetAAdminAsync(string UserName = default, int UserID = 0);
        /// <summary>
        /// getting a list admin
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<Admin>> GetAdminListAsync();
        
        /// <summary>
        /// Delteting an account 
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        Task DeleteAccountAsync(string UserName = default, int UserID = 0);




    }
}
