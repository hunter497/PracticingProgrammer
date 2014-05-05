using System;
using System.Collections.Generic;
using System.Data.Entity;
using Practicing_Programmer.Models;
using System.Linq;
using System.Web;

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