using Practicing_Programmer.Models;
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