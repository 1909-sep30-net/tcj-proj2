using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using HelpByPros.BusinessLogic;
using HelpByPros.BusinessLogic.IRepo;
using System.Linq;
using Microsoft.EntityFrameworkCore;

namespace HelpByPros.DataAccess.Repo
{
    /// <summary>
    /// Accessor and Mutator methods for allowing the BusinessLogic class to interact with the PostGre Databse
    /// Getters and Setters
    /// </summary>
    public class ForumRepo : BusinessLogic.IRepo.IForumRepo
    {

        #region Specify the repository and any related logger

        private readonly Entities.PH_DbContext _dbContext;

        //private readonly ILogger<RestaurantRepository> _logger;



        /// <summary>
        /// Initializes a new restaurant repository given a suitable restaurant data source.
        /// </summary>
        /// <param name="dbContext">The data source</param>
        /// <param name="logger">The logger</param>
        
        public ForumRepo(Entities.PH_DbContext dbContext /*, reference a logger here _logger */ )
        {
            
            _dbContext = dbContext ?? throw new ArgumentNullException(nameof(dbContext));


            //_logger = logger ?? throw new ArgumentNullException(nameof(logger));
        }

        #endregion


        //////////////////////////////////////////////////////////////////////////////////////////////

        #region Setters: Place text from a question and/or answer onto onto the database.
        /// <summary>
        /// Set a specific answer on the database
        /// </summary>
        async Task IForumRepo.AddAnswerToDBAsync(BusinessLogic.Answer a)
        {
            
            await _dbContext.AddAsync( Mapper.MapAnswer(a) );


        }
                       
        /// <summary>
		/// Add a specific question to the database
		/// </summary>
        async Task IForumRepo.AddQuestionToDBAsync(Question q)
        {
            await _dbContext.AddAsync( Mapper.MapQuestion(q) );
        }


        //////////////////////////////////////////////////////////////////////////////////////////////


        #region Getters: Get an entry from the database and convert it to a business-logic object.



        /// <summary>
        /// Returns a question from the database as a BusinessLogic.Question object.
        /// </summary>
        async Task<BusinessLogic.Question> IForumRepo.GetQuestionAsync(int qID)
        {
            //get the question
            return Mapper.MapQuestion( await _dbContext.Questions.FindAsync( qID ) );

        }

        /// <summary>
        /// 
        /// </summary>
        async Task<string> IForumRepo.GetQuestHeaderAsync(int qID)
        {
            //Note, due to the ammount of traffic this generates, probably a good idea to NOT have to pull
            //   the whole string for a question when we JUST need the headers.


            //There are no question headers, in the meantime, get a string.
            ///   get question, get the question's text, return a substring of that text.
            return (Mapper.MapQuestion(await _dbContext.Questions.FindAsync(qID))).UserQuestion.Substring(0, 40);

            //use then when we can get a "QuestionHeader" table on the server.
            //return await _dbContext.QuestionHeader.FindAsync( qID );


        }

        /// <summary>
        /// Return a very specific business logic version of the Answer from the database
        /// 
        /// </summary>
        async Task<BusinessLogic.Answer> IForumRepo.GetAnAnswerAsyc(int aID)
        {
            return Mapper.MapAnswer( await _dbContext.Answers.FindAsync(aID) );
        }


        //code snippets
        //single element linq query
        //var d = await db.Employee.FirstOrDefaultAsync(x => x.FirstName == "Jack");
        //
        //list result
        //var d = await db.Employee.Where(x => x.FirstName == "Jack").ToListAsync();

        /// <summary>
        /// Return an answer to a specific question.
        /// </summary>
        /// <param name="aID"></param>
        /// <returns></returns>
        /// 
        async Task<BusinessLogic.Answer> IForumRepo.GetOneAnswerAsyc(int qID)
        {

            //get the best answer
            return await getBest(qID) ;

        }

        /// <summary>
        /// Return the best answer
        /// </summary>
        async Task<BusinessLogic.Answer> IForumRepo.GetBestAnswer(int qID)
        {
            //get the best answer
            return await getBest(qID);
        }

        /// <summary>
        /// Helper method to get the best or single answer to a question.
        /// </summary>
        /// <param name="qID"></param>
        /// <returns></returns>
        async Task<BusinessLogic.Answer> getBest(int qID)
        {
            var bestAnswer = await _dbContext.Answers.FirstOrDefaultAsync(a => a.QuestionID == qID && a.Best == true);
            return Mapper.MapAnswer(bestAnswer);
        }



        /// <summary>
        /// Get the first page for each answer
        /// </summary>
        async Task<IEnumerable<Answer>> IForumRepo.GetAnswerListAsync(int qID, int start, int qty)
        {
            //declare the list
            List<Answer> ansList = new List<Answer>();
            
            
            //first get the best answer.  
            Answer first = await getBest(qID);
            
            //add the first answer
            ansList.Add(first);


            //Get qty-1 entries
            //this part can't be asynch, yet
            //
            // In Answers:
            //  skip however many need to
            //  to get the next set
            //  get that set

            var others = (from ans in _dbContext.Answers
                          where ans.Id == qID
                          select ans).Skip(start).Take(qty).ToList();


            //convert them to BusinessLogic objects.
            foreach(var item in others)
            {
                ansList.Add(Mapper.MapAnswer(item) );
            }

            return ansList;

        }
        #endregion

        /// <summary>
        /// Get the next page for each answer
        /// </summary>
        List<Answer> IForumRepo.GetMoreAnswers(int qID, int start, int qty)
        {

            //declare the list
            List<Answer> ansList = new List<Answer>();
            
            //
            // In Answers:
            //  skip however many need to
            //  to get the next set
            //  get that set

            var ans_query = (from ans in _dbContext.Answers
                          where ans.Id == qID
                          select ans).Skip(start).Take(qty).ToList();


            //convert them to BusinessLogic objects.
            foreach (var item in ans_query)
            {
                ansList.Add(Mapper.MapAnswer(item));
            }

            return ansList;

        }
        


        /// <summary>
        /// Get a list of questions based on category.
        /// </summary>
        List<Question> IForumRepo.GetQuestionList(Category category, int start, int qty)
        {
            List<Question> questionList = new List<Question>();

            //convert enum to string.
            string catName = Enum.GetName(typeof(Category), category);



            //Will work once postGre is installed as a nuget package
            /*
            var others = (from question in _dbContext.Questions
                          where question.Category == Category.ComputerScience
                          select question).Skip(start).Take(qty).ToList();
            */

            //On the database, the category is represented ONLY by a number
            /*
             
            //compare the two strings.
            var questions = (from question in _dbContext.Questions
                          where Enum.GetName(typeof(Category), question.Category)  == catName
                          select question).Skip(start).Take(qty);
            */


            //compare two integers, Category is stored as an integer on the postGre SQL server.
            var questions = (from question in _dbContext.Questions.Include(x => x.Users)
                             where question.Category  ==category.ToString() 
                             select question).Skip(start).Take(qty);
                       

            //convert them to BusinessLogic objects.
            foreach (var question in questions)
            {
                questionList.Add(Mapper.MapQuestion( question ) );
            }

            return questionList;

        }



       






        #endregion


    }//end class

}//end namespace
