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
            catch
            {
                throw new InvalidOperationException("There is already an existed username, phone, or email");
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
                var z = await y.Where(x => x.User.Username == UserName).FirstOrDefaultAsync();
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


        public async Task ModifyQuestion(Question ques, string username)
        {
            try
            {
                var q = (await GetUsersQuestion(username)).ToList();

                Question question = q.Where(x => x.Id == ques.Id).First();

                var e = Mapper.MapQuestion(question);
                _context.Entry(e).CurrentValues.SetValues(e);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no question existed");
            }
        }

        public async Task DeleteQuestion(int QuestionID, string username)
        {
            try
            {
                var q = (await GetUsersQuestion(username)).ToList();

                Question question = q.Where(x => x.Id == QuestionID).First();
                var answers = _context.Answers.Where(b => b.QuestionID == QuestionID);
                foreach (var ans in answers)
                {
                    _context.Remove(ans);
                }

                var e = Mapper.MapQuestion(question);
                _context.Remove(e);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no question existed");
            }

        }
        public async Task<IEnumerable<Answer>> GetUsersAnswer(string UserName)
        {
            var a = await _context.Answers.Include(x => x.User).ToListAsync();
            List<Answer> xList = new List<Answer>();

            foreach (Answers ans in a)
            {
                xList.Add(Mapper.MapAnswer(ans));

            }
            return xList;
        }

        public async Task<IEnumerable<Question>> GetUsersQuestion(string UserName)
        {
            var q = await _context.Questions.Include(x => x.Users).ToListAsync();
            List<Question> xList = new List<Question>();

            foreach (Questions ques in q)
            {
                xList.Add(Mapper.MapQuestion(ques));

            }
            return xList;
        }

        public async Task ModifyAnswer(int answerID, string username)
        {
            try
            {
                var q = (await GetUsersAnswer(username)).ToList();

                Answer a = q.Where(x => x.ID == answerID).First();

                var e = Mapper.MapAnswer(a);
                _context.Entry(e).CurrentValues.SetValues(e);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such response to the question existed");
            }

        }

        public async Task<User> GetAUser(string userName)
        {
            try
            {
                var y = _context.Users.Include(x => x.Id);
                var z = await y.Where(x => x.Username == userName).FirstOrDefaultAsync();
                return Mapper.MapUser(z);
            }
            catch (ArgumentNullException ex)
            {
                throw new ArgumentNullException("There is no such user: " + ex);
            }
        }

        public async Task DeleteAAnswer(Answer ans, string userName)
        {
            try
            {
                var q = (await GetUsersAnswer(userName));
                var x = q.Where(x => x.ID == ans.ID).First();

                var e = Mapper.MapAnswer(x);
                _context.Remove(e);
                await _context.SaveChangesAsync();
            }
            catch
            {
                throw new InvalidOperationException("There is no such answer existed");
            }
        }



        #endregion
    }
}
