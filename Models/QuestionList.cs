using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyTogether.Models
{
   public class QuestionList
    {
        public int QuestionId { get; set; }
        public string QuestionMain { get; set; }
        public string CorectAnswer { get; set; }
        public string IncorectFirst { get; set; }
        public string IncorectSecond { get; set; }
        public string IncorectThird { get; set; }
        public string  Hint { get; set; }
    }
}
