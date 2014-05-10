using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Practicing_Programmer.Models
{
    public class Kata
    {
        public int KataID { get; set; }
        public string Title { get; set; }
        public string Summary { get; set; }
        public string Difficulty { get; set; }
        public string Category { get; set; }
        public string Content { get; set; }
        public string GithubLink { get; set; } 
        
    }
}