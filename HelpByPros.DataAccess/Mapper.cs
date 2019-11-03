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
        /// DataBase.Entities converted to BusinessLogic-object
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Question MapQuestion(Questions a)
        {

            var x = new Question()
            {

                Category = (Category)a.Category.Id,  //the category of the question.

                UserQuestion = a.UserQuestion,       //the body text for the question

                //server does not store , specifically, who wrote the answers for a specific question on the Questions-table
                //therefore it cannot be mapped to the BL-version.
                

                Author = MapUser(a.Users),          //who wrote it?

                Answered = a.Answered,              //check if answered

                Id = a.Id                           //we get the automatically generated ID from the server

            };

            return x;


        }


        /// <summary>
        /// From BusinessLogic.Question to DataAccess.Entities.Questions
        /// 
        /// </summary>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Questions MapQuestion(Question a)
        {

            var x = new Questions();

            x.Category.Category = (Category)x.Category.Id;  //category number

            x.UserQuestion = a.UserQuestion;                //body text of question.
            
            //may only need to map to the Professional who wrote this.
            x.UsersID = a.Author.Id;                        //who asked the question

            x.Answered = a.Answered;                        //was the question answered?

            //MISSING ITEMS FROM DataBase.Entities.Questions
            //upvote
            //downvote

            
            //auto-generated on server
            //x.Id = a.Id;

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
            /*
             *  
             *          
             *          

                public int QuestionID { get; set; }
                public Questions Question { get; set; }
                public int UpVote { get; set; }
                public int DownVote { get; set; }
                public int UserID { get; set; }
             * */
            //map


            x.QuestionID = a.AnsQuestionID;             //what question does this answer pertain to?
            
            x.Best = a.Best;                            //is this the best answer?

            x.DownVote = a.DownVote;                    //upvote and downvote values.
                                                        //       ^
            x.UpVote = a.UpVote;                        //       |
            
            x.Sources = a.Source;                       // Citation for source-material on answer

            x.UserID = a.Author.Id;                     //who wrote the answer?

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
                AnswerText = a.Answer,          //the body text of the answer

                Author = MapUser(a.User),       //the user who wrote it.
                
                Best = a.Best,                  //is this the best answer?
                
                DownVote = a.DownVote,          //upvote value
                
                UpVote = a.UpVote,              //downvote value
                
                Source = a.Sources              //citations, the source of information to support the answer.
            };

            return x;
        }




    }
}
