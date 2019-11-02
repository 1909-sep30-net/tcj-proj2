using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using HelpByPros.DataAccess.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace HelpByPros.DataAccess.Repo
{
    public class UserRepo : IUserRepo
    {
        private readonly PH_DbContext _context;

        public UserRepo(PH_DbContext context)
        {
            _context = context;
        }

        #region Add information to db
        public async Task AddMemberAsync(Member m)
        {
            var e = Mapper.MapMember(m);

            _context.Add(e);
            await _context.SaveChangesAsync();
        }

        public async Task AddProfessionalAsync(Professional p)
        {
            var e = Mapper.MapProfessonal(p);

            _context.Add(e);
            await _context.SaveChangesAsync();
        }
        #endregion

        #region Get Infomation from database

        /// <summary>
        /// getting a member if it exist if not then exeception will be thrown instead
        /// </summary>
        /// <param name="UserName"> optional attribute </param>
        /// <param name="UserID">optional attribute </param>
        /// <returns></returns>
        public async Task<Member> GetAMemberAsync(string UserName=default, int UserID = 0)
        {
            try
            {
                var x = await _context.Members.Include(x => x.UserID == UserID || x.User.Username == UserName).FirstOrDefaultAsync();
                return Mapper.MapMember(x);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("There is no such Member: " + ex);
            }
        }
        /// <summary>
        /// getting a Professonal if it exist if not then exeception will be thrown instead
        /// </summary>
        /// <param name="UserName"> optional attribute </param>
        /// <param name="UserID">optional attribute </param>
        /// <returns></returns>
        public async Task<Professional> GetAProfessionalAsync(string UserName=default, int UserID = 0)
        {
            try
            {
                var x = await _context.Professionals.Include(x => x.UserID == UserID || x.User.Username == UserName).FirstOrDefaultAsync();
                return Mapper.MapProfessonal(x);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("There is no such Professional: " + ex);
            }
        }

       



        public async Task<IEnumerable<Member>> GetMemberListAsync()
        {
            var x = await _context.Members.Include(x => x.User).ToListAsync();
            List<Member> xList = new List<Member>();


            foreach (Members a in x)
            {
                xList.Add(Mapper.MapMember(a));
            }

            return xList;
        }

        public async Task<IEnumerable<Professional>> GetProfessionalListAsync()
        {
            var x = await _context.Professionals.Include(x => x.User).ToListAsync();
            List<Professional> xList = new List<Professional>();


            foreach (Professionals a in x)
            {
                xList.Add(Mapper.MapProfessonal(a));
            }

            return xList;
        }

        #endregion
    }
}
