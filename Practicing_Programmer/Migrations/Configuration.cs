using Practicing_Programmer.Models;

namespace Practicing_Programmer.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Practicing_Programmer.DAL.PracticingProgrammerDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(Practicing_Programmer.DAL.PracticingProgrammerDb context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
                context.Katas.AddOrUpdate(
                  new Kata { Title = "FizzBuzz", 
                                Summary = "    FizzBuzz is a well known tech screen question used by many companies. " +
                                "A basic exercise that is meant to warm up a prospective programmer for more difficult questions.", 
                                Category = "Tech Screen", 
                                Content = "  A beginner programming problem that consists of counting with a twist. " +
                                          "In this code kata, write a program that prints the numbers from 1 to 100. " +
                                          "If the number is a multiple of three, print 'Fizz' instead of the number, if it is a multiple " +
                                          "of five, print 'Buzz', and if it is a multiple of both three and five, print 'FizzBuzz.'", 
                                Difficulty = "Beginner", 
                                GithubLink = "",
                                TestOutput = "1, 2, Fizz, 4, Buzz, Fizz, 7, 8, Fizz, Buzz, 11, Fizz, 13, 14, FizzBuzz..."}
                );
            //
        }
    }
}
