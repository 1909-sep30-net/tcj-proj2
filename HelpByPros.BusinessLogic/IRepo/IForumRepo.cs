
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace HelpByPros.BusinessLogic.IRepo
{
    public interface IForumRepo
    {

        # region Get Question/Answer Data
        /// <summary>
        /// Get Question from Database
        /// </summary>
        Task GetQuestionAsync(int qID);

        /// <summary>
        /// Get Question Header For a Qustion
        /// </summary>
        Task GetQuestHeaderAsync(int qID);

        /// <summary>
        /// Get Answer from Database
        /// </summary>
        Task GetAnAnswerAsyc(int aID);

        /// <summary>
        /// Get a list of answers to a given question, and how many to view.
        /// </summary>
        Task<IEnumerable<Answer>> GetAnswerListAsync(int aID, int qty);

        #endregion

        #region Add Question/AnswerData
        /// <summary>
        /// Add a question to the database
        /// </summary>
        Task AddQuestionToDBAsync(Question q);

        /// <summary>
        /// Add a question to the database
        /// </summary>
        Task AddAnswerToDBAsync(Answer q);
        #endregion
    }
}
