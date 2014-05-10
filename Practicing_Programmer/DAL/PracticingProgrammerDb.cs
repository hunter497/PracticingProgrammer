using System.Data.Entity;
using Practicing_Programmer.Models;

namespace Practicing_Programmer.DAL
{
    public class PracticingProgrammerDb : DbContext
    {
        public DbSet<Kata> Katas { get; set; }
        public DbSet<Question> Questions { get; set; }
    }
}