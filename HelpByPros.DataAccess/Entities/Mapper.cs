using System;
using System.Collections.Generic;
using System.Text;
using HelpByPros.BusinessLogic;

using System.Linq;

//NOTE: how to make a new unique-safe ID that is SQL compliant
//
// string uniqueID = new Guid().ToString();


namespace HelpByPros.DataAccess.Entities
{
    /// <summary>
    /// Maps Classes in BusinessLogic to DataAccess and vise versa
    /// Required per code-first approach to Entity Framework
    /// </summary>
    class Mapper
    {
        //***missing BusinessLogic AccountInfo***


        // To Business Logic


        public static BusinessLogic.Admin Admin_toBL(Entities.Admins admin)
        {
            return new BusinessLogic.Admin() 
            {
                //Implement these variables in business logic
                //Id = admin.Id,
                //User = admin.User
            };

        }

        public static BusinessLogic.Answer Answer_toBL(PH_DbContext context, Entities.Answers answer)
        {
            //convert Author to a business-class user.

            var theAuthor = context.Users.FirstOrDefault(a => a.Id == answer.UserID);

            IUser user = User_ToBL( theAuthor);

            return new BusinessLogic.Answer()
            {

                Best = false,//missing in db

                //missing Question ID

                //change to an integer.  Use a method to look up the author as needed.
                //                  

                Author = user,

                UpVote = answer.UpVote, 
                DownVote = answer.DownVote,
                Source = answer.QuestionID


            };
        }

        //Requires Correction

        //is an Enum locally, and the database can and will change.
        // use a GUID to identify the category
        // local business logic will also require the GUID, or the
        // resulting string
        //    ID        CategoryName        GUID        
        //
        //GUID should be VARCHAR if GUID is not an acceptable SQL data-type.

            /*
        public static BusinessLogic.Category Category(Entities.Answers answer)
        {
            return new BusinessLogic.Category()
           { 
                          
            };
        }
        *
        
        
        //Requires correction
        //unimplimented on the database
        /*
        public static BusinessLogic.IPayment Paymemt(Entities.Answers answer)
        {
            return new BusinessLogic.IPayment()
            {
                points = 0 //Requires correction
            };
        }
        */

        /*
        //"text" has no entry in Data Logic
        public static BusinessLogic.ITextEntry TextEntry(Entities.Text textEntry)
        {

            return new BusinessLogic.ITextEntry()
            {
                Text = "Table missing"
                Author = new IUser();
            };
        }
        */

        public static BusinessLogic.Member Member(PH_DbContext context, Entities.Members member)
        {
            //Will not impliment here, impliment as method in the class: leads to infinite loops
            //select all questions for this member
            /*
             * var questList = (from question in context.Questions
                           where (question.Id == member.Id)
                           select question).ToList();

            //could use this, but I know the above works
            //var qlistLinq = context.Questions.Where(q => q.UsersID == member.Id).Select( q => q);



            //convert and add to this list.
            List < BusinessLogic.Question > busQ = new List<BusinessLogic.Question>();

            foreach (var q in questList)
            {
                busQ.Add( Question_toBL( context, q ) );
            }

            
            */

            return new BusinessLogic.Member()
            {
                //assign the questions to this member.
                //Question = busQ,
                
                //Requires Correction
                //missing from database
                PointAvailable = 0
            };

        }

        /*//cannot be mappted till Professional has an Interface
       public BusinessLogic.Professional Professional_toBL(Entities.Professional professional)
       {
            return new BusinessLogic.Professional()
            {
                //credential is the same as category for a question and must reference the same thing.
                //Credential = 

                //place into a getter method: due to combinatorial explosion in database-queries.
                //Question = 

                //Requires Correction
                PointsAvailable = 0, //missing from database
                YearsOfExp = 0; //missing from database
           };
       }
       */

        /*//is an enum
        public static BusinessLogic.Title Title(Entities.Answers answer)
        {
            return new BusinessLogic.Title()
            {
                Title =
            };
        }
        */

        private static Question Question_toBL(PH_DbContext context, HelpByPros.DataAccess.Entities.Questions question)
        {

            //Place this into a helper method
            /*
            var ansList = (from ans in context.Answers
                          where (ans.QuestionID == question.Id)
                          select ans).ToList();
            

            //convert and add to this list.
            List<BusinessLogic.Question> busQ = new List<BusinessLogic.Question>();

            foreach (var a in ansList)
            {
                busQ.Add(Answer_toBL(context, a));
            }
            */

            
            return new HelpByPros.BusinessLogic.Question()
            {

                //Requres correction: category

                //Category = Category.English, 

                //place into helper method: getUserQuestion
                //UserQuestion = question.UserQuestion,

                //get with a helper-method, answer, otherwise question will try to get a question in an infintie loop
                //Answer = 0,

                //Needs a reference to a text field
                //Needs a reference to a question title

                //requires a boolean variable on the 
                //Answered = 


            };
        }




        public static BusinessLogic.User User_ToBL(Entities.Users user)
        {
        return new BusinessLogic.User()
        {
            

            FirstName = user.FirstName,
            LastName = user.LastName,
            Email = user.Email,
            Username = user.Username

                //Up to the client to keep track as to if they were or were not logged in.
                //Requires a GetPassword method
                //
                //Hypothetically, does the server need someone's password every time they are looked up?
                //query the SQL server only as needed
                //    
                //Password = user.Password;

            };
        }


    }
}
