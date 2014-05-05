using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicing_Programmer.Models
{
    public class Question
    {
        public int QuestionID { get; set; }
        public string Inquiry { get; set; }
        public string Category { get; set; }
        public string Answer { get; set; }
        public string MoreInfo { get; set; }
    }
}