using System.Data.Entity;
using Practicing_Programmer.Models;

namespace Practicing_Programmer.DAL
{
    public class KatasContext : DbContext
    {
        public KatasContext() : base("KataContext")
        {
            
        }

        public DbSet<Kata> Katas { get; set; }
    }
}