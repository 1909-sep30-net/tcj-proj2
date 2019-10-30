using System;
using System.Collections.Generic;
using System.Text;

namespace HelpByPros.BusinessLogic
{
    class Professional:User
    {
        /// <summary>
        /// Linkeldn info
        /// </summary>
        public string Crediential { get; set; }
        public List<Question> Question { get; set; } = new List<Question>();

        public int PointAvailable { get; set; }
        
        public int YearsOfExp { get; set; }
    }
}
