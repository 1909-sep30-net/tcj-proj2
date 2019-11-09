using HelpByPros.BusinessLogic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelpByPros.Api.Model
{
    public class HomeModel
    {
        public List<Question> QuestionList { get; set; }

        private List<string> _cateList= new List<string>();
        public List<string> CategoryList {
            get
            {
                return _cateList;
            }
            set
            {
                 foreach (string x in Enum.GetNames(typeof(Category)))
                {
                    _cateList.Add(x);
                }
            }
           
        }
    }
}
