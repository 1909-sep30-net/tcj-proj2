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
            try
            {
                var e = Mapper.MapMember(m);
                _context.Add(e);
                await _context.SaveChangesAsync();
            }
            catch(DbUpdateException ex)
            {
                throw new InvalidOperationException("There is already an existed username, phone, or email" + ex);
            }
        }
        public async Task AddProfessionalAsync(Professional p)
        {

            var e = Mapper.MapProfessonal(p);

            try
            {
                _context.Add(e);

                await _context.SaveChangesAsync();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException("Duplicate info in unique Column");

            }
        }



        #endregion

        #region Get Infomation from database

        /// <summary>
        /// getting a member if it exist if not then exeception will be thrown instead
        /// </summary>
        /// <param name="UserName"> optional attribute </param>
        /// <param name="UserID">optional attribute </param>
        /// <returns></returns>
        public async Task<Member> GetAMemberAsync(string UserName)
        {
            try
            {
                var y = _context.Members.Include(x => x.User).Include(j => j.AccInfo);
                var z = await y.Where(x => x.User.Username == UserName).FirstAsync();
                return Mapper.MapMember(z);
            }
            catch (ArgumentNullException)
            {
                throw new ArgumentNullException();
            }
            catch (InvalidOperationException)
            {
                throw new InvalidOperationException();

            }
        }

        /// <summary>
        /// getting a Professonal if it exist if not then exeception will be thrown instead
        /// </summary>
        /// <param name="UserName"> optional attribute </param>
        /// <param name="UserID">optional attribute </param>
        /// <returns></returns>
        public async Task<Professional> GetAProfessionalAsync(string UserName)
        {
            try
            {
                var y = _context.Professionals.Include(x => x.User).Include(j => j.AccInfo);
                var z = await y.Where(x => x.User.Username == UserName).FirstAsync();
                return Mapper.MapProfessonal(z);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("There is no such Professional: " + ex);
            }
        }

        public async Task<IEnumerable<Member>> GetMemberListAsync()
        {
            var x = await _context.Members.Include(x => x.User).Include(x => x.AccInfo).ToListAsync();
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


        public async Task DeleteQuestionAsync(int QuestionID)
        {
            try
            {

                var questions = await _context.Questions.Where(x => x.Id == QuestionID).FirstAsync();
                var answers = _context.Answers.Where(b => b.QuestionID == QuestionID);
                foreach (var ans in answers)
                {
                    _context.Answers.Remove(ans);
                }

                _context.Questions.Remove(questions);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no question existed");
            }

        }
        public async Task<IEnumerable<Answer>> GetUsersAnswerAsync(string UserName)
        {
            var a = await _context.Answers.Include(x => x.User).ToListAsync();
            List<Answer> xList = new List<Answer>();

            foreach (Answers ans in a)
            {
                xList.Add(Mapper.MapAnswer(ans));

            }
            return xList;
        }

        public async Task<IEnumerable<Question>> GetUsersQuestionAsync(string UserName)
        {
            var q = await _context.Questions.Include(x => x.Users).ToListAsync();
            List<Question> xList = new List<Question>();

            foreach (Questions ques in q)
            {
                xList.Add(Mapper.MapQuestion(ques));

            }
            return xList;
        }

        public async Task ModifyAnswerAsync(Answer ans)
        {
            try
            {             
                if(ans.Author == null)
                {
                    throw new InvalidOperationException("No User is logged in");

                }

                var e = Mapper.MapAnswer(ans);
                var oldQ = _context.Answers.Where(x => x.Id == ans.ID).FirstOrDefault();

                _context.Entry(oldQ).CurrentValues.SetValues(e);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such answer to the question existed");
            }

        }

        public async Task ModifyQuestionAsync(Question ques)
        {
            if(ques.Author == null)
            {
                throw new InvalidOperationException("No User is logged in");
            }

            var e = Mapper.MapQuestion(ques);
            var oldQ = _context.Questions.Where(x => x.Id == ques.Id).FirstOrDefault();
            _context.Entry(oldQ).CurrentValues.SetValues(e);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such Question.");

            }



        }
        public async Task<User> GetAUserAsync(string userName)
        {
            try
            {
                var y = _context.Users;
                var z = await y.Where(x => x.Username == userName).FirstOrDefaultAsync();
                return Mapper.MapUser(z);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("There is no such user: " + ex);
            }
        }

        public async Task DeleteAAnswerAsync(int ansID)
        {
           
               var ans =_context.Answers.Where(a => a.Id == ansID);
            try
            {

                _context.Answers.Remove(ans.FirstOrDefault());

                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such Answer");

            }

        }

        public async Task ModifyUserInfoAsync(User User)
        {
            var oldUserInfo = await _context.Users.Where(x => x.Username == User.Username).FirstAsync();

            var newUser = Mapper.MapUser(User);
            newUser.Id = oldUserInfo.Id;
            try
            {
                _context.Entry(oldUserInfo).CurrentValues.SetValues(newUser);

                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such User." );

            }

        }

        public async Task ModifyProfessionalInfoAsync(Professional user)
        {
            var UsersList = await _context.Professionals.Include(x => x.User).Include(x => x.AccInfo).ToListAsync();
            try
            {

                var oldUserInfo = await _context.Professionals.Where(x => x.User.Username == user.Username).FirstAsync();

            var newUser = Mapper.MapProfessonal(user, oldUserInfo);
           
                _context.Entry(oldUserInfo).CurrentValues.SetValues(newUser);

                await ModifyUserInfoAsync(user);



                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such User.");

            }
        }

            public async Task ModifyMemberInfoAsync(Member user)
        {
            var UsersList = await _context.Members.Include(x => x.User).Include(x => x.AccInfo).ToListAsync();
            try
            {

                var oldUserInfo = await _context.Members.Where(x => x.User.Username == user.Username).FirstAsync();

            var newUser = Mapper.MapMember(user, oldUserInfo);
              _context.Entry(oldUserInfo).CurrentValues.SetValues(newUser);
                await ModifyUserInfoAsync(user);

                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such User.");

            }
        }

        public Task AddPoints(string username, int Points)
        {
            throw new NotImplementedException();
        }

        public async Task ModifyAnswerUpVotes( int points, int ansID)
        {
            try
            {
                var oldAnswer = await _context.Answers.Where(x => x.Id == ansID).FirstAsync(); ;
                oldAnswer.UpVote= points;

                _context.Entry(oldAnswer).CurrentValues.SetValues(oldAnswer);
                await _context.SaveChangesAsync();

            }
            catch
            {
                throw new InvalidOperationException("There is no answer.");

            }
        }
        public async Task ModifyAnswerDownVotes(int points, int ansID)
        {
            try
            {
                var oldAnswer = await _context.Answers.Where(x => x.Id == ansID).FirstAsync(); ;
                oldAnswer.DownVote = points;

                _context.Entry(oldAnswer).CurrentValues.SetValues(oldAnswer);
                await _context.SaveChangesAsync();

            }
            catch
            {
                throw new InvalidOperationException("There is no answer.");

            }
        }

        public async Task<List<string>> GetPhoneListForProfessionalExpertise(string category)
        {
          var x  = await _context.Professionals.Include(x => x.User).ToListAsync();
            var z = x.Where(x => x.Expertise == category);
            var y = z.Select(x => x.User.Phone).ToList();

            return y;
        }

        public async Task<string> GetPhoneOfAMember(string username)
        {
            var x = await _context.Members.Include(x => x.User).ToListAsync();

            var z = x.Where(x => x.User.Username == username);
            var y = z.Select(x => x.User.Phone).FirstOrDefault();

            return y;
        }

        public async Task<string> GetAuthorOfQuestion(int qid)
        {
            var x = await _context.Questions.Include(x => x.Users).ToListAsync();
            var z = x.Where(x => x.Id == qid);
            var y = z.Select(x => x.Users.Phone).FirstOrDefault();
            return y;

        }


        #endregion
    }
}
