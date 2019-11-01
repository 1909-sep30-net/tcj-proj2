using System.Collections.Generic;
using System.Threading.Tasks;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;

namespace HelpByPros.DataAccess.Repo
{
    public class UserRepo : IUserRepo
    {
        #region Add information to db
        public Task AddAdminAsync(Admin a)
        {

            throw new System.NotImplementedException();
        }

        public Task AddMemberAsync(Member m)
        {
            throw new System.NotImplementedException();
        }

        public Task AddProfessionalAsync(Professional p)
        {
            throw new System.NotImplementedException();
        }
        #endregion

        #region Get Infomation from database

        public Task<Member> GetAAdminAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Admin>> GetAdminListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<Member> GetAMemberAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<Member> GetAProfessionalAsync(int id)
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Member>> GetMemberListAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task<IEnumerable<Professional>> GetProfessionalListAsync()
        {
            throw new System.NotImplementedException();
        }
        #endregion
    }
}
