using Practicing_Programmer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace Practicing_Programmer.DAL
{
    public class QuestionsContext : DbContext
    {
        public QuestionsContext() : base("QuestionContext")
        {
            
        }

        public DbSet<Question> Questions { get; set; }
    }
}