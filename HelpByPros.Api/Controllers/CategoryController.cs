using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HelpByPros.BusinessLogic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HelpByPros.Api.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        [HttpGet]
        public List<string> GetCategory()
        {
            List<string> ListOfCategory = new List<string>();
            foreach (var x in Enum.GetValues(typeof(Category)).OfType<Category>().ToArray())
            {
                ListOfCategory.Add(x.ToString());
            }
                return ListOfCategory;
        }

    }
}