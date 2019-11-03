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
        Task<Member> GetAMemberAsync(string UserName);
        /// <summary>
        /// getting a professional
        /// </summary>
        /// <returns></returns>
        Task<Professional> GetAProfessionalAsync(string UserName);



        /// <summary>
        /// getting a list of user history of questions
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        Task<IEnumerable<Question>> GetUsersQuestion(string UserName);

        /// <summary>
        /// getting a list of user history of answers
        /// </summary>
        /// <param name="UserName"></param>
        /// <returns></returns>
        Task<IEnumerable<Answer>> GetUsersAnswer(string UserName);


        #endregion


        #region UserPower

        /// <summary>
        /// The question is modifiable 
        /// </summary>
        /// <param name="QuestionID"></param>
        /// /// <param username="QuestionID"> use for authentication: only user is allowed to modify their own question </param>
        /// <returns></returns>
        Task ModifyQuestion(int questionID, string username);

        /// <summary>
        /// The question is deleteable 
        /// </summary>
        /// <param name="QuestionID"> To identify the question </param>
        /// /// <param username="QuestionID"> use for authentication: only user is allowed to delete their own question </param>
        /// <returns></returns>
        Task DeleteQuestion(int QuestionID, string username);





        #endregion

    }
}
