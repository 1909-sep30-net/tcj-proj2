using HelpByPros.BusinessLogic;
using HelpByPros.DataAccess.Entities;

namespace HelpByPros.DataAccess
{
    public class Mapper
    {

        public static User MapUser(Users u)
        {

            return new User
            {
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Username = u.Username,
                Password = u.Password,
                Phone = u.Phone,
                Profile_Pic = u.Profile_Pic
            };

          
        }
        public static Users MapUser(User u)
        {
            return new Users
            {
                Email = u.Email,
                FirstName = u.FirstName,
                LastName = u.LastName,
                Username = u.Username,
                Password = u.Password,
                Phone = u.Phone,
                Profile_Pic = u.Profile_Pic
            };


        }
        /// <summary>
        /// Entities Members converted to Business Logic Member class
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Member MapMember(Members m)
        {

         

            return new Member
             {
                
                 Email = m.User.Email,
                 FirstName = m.User.FirstName,
                 LastName = m.User.LastName,
                 Username = m.User.Username,
                 Password = m.User.Password,
                 Phone = m.User.Phone,
                 Profile_Pic = m.User.Profile_Pic,
                 PointAvailable= m.AccInfo.PointAvailable

             };
  

        }
        /// <summary>
        /// Business Logic Members converted to Entities class
        /// </summary>
        /// <param name="m"></param>
        /// <returns></returns>
        public static Members MapMember(Member m)
        {
            var x = new Members
            {
                User = MapUser(m)
                
                
            };
            x.AccInfo.PointAvailable = m.PointAvailable;
            return x;          

        }
        /// <summary>
        /// Entities Professonal converted to Business Logic Professonal class
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Professional MapProfessonal(Professionals p)
        {
            
            return new Professional
            {
                Email = p.User.Email,
                FirstName = p.User.FirstName,
                LastName = p.User.LastName,
                Username = p.User.Username,
                Password = p.User.Password,
                Phone = p.User.Phone,
                Profile_Pic = p.User.Profile_Pic,
                PointAvailable = p.AccInfo.PointAvailable

            };

         


        }
        /// <summary>
        /// Business Logic Professonal converted to entities class
        /// </summary>
        /// <param name="p"></param>
        /// <returns></returns>
        public static Professionals MapProfessonal(Professional p)
        {
            var x = new Professionals
            {
                User = MapUser(p)
            };
            x.AccInfo.PointAvailable = p.PointAvailable;
            x.Profession.Title = p.Title;
            x.YearsOfExp = p.YearsOfExp;
            return x;

        }

        /// <summary>
        /// Entities converted to Business Logic  class
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Admin MapAdmin(Admins a)
        {
            return new Admin
            {
                Email = a.User.Email,
                FirstName = a.User.FirstName,
                LastName = a.User.LastName,
                Username = a.User.Username,
                Password = a.User.Password,
                Phone = a.User.Phone,
                Profile_Pic = a.User.Profile_Pic,                

            };


        }
        /// <summary>
        /// Business Logic converted to Entities class
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Admins MapAdmin(Admin a)
        {
            var x = new Admins
            {
                User = MapUser(a)
            };
            return x;

        }


        /// <summary>
        /// Entities converted to Business Logic  class
        ///  with included answers and user 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Question MapQuestion(Questions a)
        {

            var x = new Question();
            x.Answered = a.Answered;
            x.Author = MapUser(a.Users);

            //*** Warning!: likely to cause combinatorial explosion
            //               Queries should be handled by Linq
            foreach(Answers ans in a.AnsCollection)
            {
                x.Answer.Add(MapAnswer(ans));
            }

            x.UserQuestion = a.UserQuestion;
            x.Category = (Category)a.Category.Id;


            return x;


        }
        /// <summary>
        /// Business Logic converted to Entities class
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Questions MapQuestion(Question a)
        {
            var x = new Questions();
            x.UserQuestion = a.UserQuestion;
            x.UsersID = a.Author.Id;
            x.Category.Category = (Category) x.Category.Id;

            foreach(Answer ans in a.Answer)
            x.AnsCollection.Add(MapAnswer( ans) ) ;
            x.Id = a.Id;
            return x;

        }

        ////Corrected //////////////////


        /// <summary>
        /// Business Logic converted to Entities class
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Entities.Answers MapAnswer(BusinessLogic.Answer a)
        {
            //declare the new instance of the EF class
            DataAccess.Entities.Answers x = new DataAccess.Entities.Answers();

            //map
            x.QuestionID = 1;
            x.QuestionID = a.AnsQuestionID;
            x.Best = a.Best;
            x.DownVote = a.DownVote;
            x.UpVote = a.UpVote;
            x.Sources = a.Source;
            x.Id = a.ID;

            //Could will need to later reference a User.Profession, but that doe not exist.

            x.User = MapUser((User)a.Author); //likely to cause problems, call MapUser instead (after it is corrected) ? ***

            return x;

        }



        /// <summary>
        /// Entities converted to Business Logic  class
        ///  with included answers and user 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static BusinessLogic.Answer MapAnswer(DataAccess.Entities.Answers a)
        {

            var x = new BusinessLogic.Answer()
            {
                AnswerText = a.Answer,
                Author = MapUser(a.User),
                Best = a.Best,
                DownVote = a.DownVote,
                UpVote = a.UpVote,
                Source = a.Sources,
            };

            return x;
        }




    }
}
