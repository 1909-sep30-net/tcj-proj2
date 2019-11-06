using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using HelpByPros.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpByPros.DataAccess.Repo
{
    public class AdminRepo:IAdminRepo
    {

        private readonly PH_DbContext _context;

        public AdminRepo(PH_DbContext context)
        {
            _context = context;
        }

        public async Task AddAdminAsync(Admin a)
        {
            try
            {
                var e = Mapper.MapAdmin(a);

                _context.Add(e);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is already an existed username, phone, or email");
            }
        }
        /// <summary>
        /// future implementation
        /// </summary>
        /// <param name="UserName"></param>
        /// <param name="UserID"></param>
        /// <returns></returns>
        public Task DeleteAccountAsync(string UserName = null, int UserID = 0)
        {
            throw new NotImplementedException();
        }



        /// <summary>
        /// getting an admin if it exist if not then exeception will be thrown instead
        /// </summary>
        /// <param name="UserName"> optional attribute </param>
        /// <param name="UserID">optional attribute </param>
        /// <returns></returns>
        public async Task<Admin> GetAAdminAsync(string UserName = default, int UserID = 0)
        {
            try
            {
                var x = await _context.Admin.Include(x => x.UsersID == UserID || x.User.Username == UserName).FirstAsync();
                return Mapper.MapAdmin(x);

            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("There is no such admin: " + ex);
            }
        }

        public async Task<IEnumerable<Admin>> GetAdminListAsync()
        {

            var x = await _context.Admin.Include(y => y.User).ToListAsync();
            List<Admin> xList = new List<Admin>();


            foreach (Admins a in x)
            {
                xList.Add(Mapper.MapAdmin(a));
            }

            return xList;
        }



    }
}
