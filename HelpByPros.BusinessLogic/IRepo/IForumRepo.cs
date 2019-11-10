
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
//using HelpByPros.DataAccess;

namespace HelpByPros.BusinessLogic.IRepo
{
    public interface IForumRepo
    {

        # region Get Question/Answer Data
        /// <summary>
        /// Get Question from Database
        /// </summary>
        public Task<BusinessLogic.Question> GetQuestionAsync(int qID);

        /// <summary>
        /// Get Question Header For a Qustion
        /// </summary>
        public Task<string> GetQuestHeaderAsync(int qID);

        /// <summary>
        /// Get Answer from Database by ID
        /// </summary>
        public Task<BusinessLogic.Answer> GetAnAnswerAsyc(int aID);
        /// <summary>
        /// Get a list of answers to a given question, and how many to view.
        /// </summary>
        public Task<List<Answer>> GetAnswerListAsync(int qID, int start, int qty);

        /// <summary>
        /// Get an additional list of answers for the next page of questions.
        /// </summary>
        public List<Answer> GetMoreAnswers(int qID, int start, int qty);

        /// <summary>
        /// Get a list of questions based on category
        /// </summary>
        public List<Question> GetQuestionList(Category category, int start, int qty);

        #endregion



        #region Add Question/AnswerData
        /// <summary>
        /// Add a question to the database
        /// </summary>
        public Task AddQuestionAsync(Question q);

        /// <summary>
        /// Add a question to the database
        /// </summary>
        public Task AddAnswerAsync(Answer a);
        #endregion
    }
}
