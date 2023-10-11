using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace _21__Getters_and_setters
{
    internal class movie
    {
        public string title;
        public string director;
        private string rating;

        public movie(string aTitle, string aDirector, string aRating)
        {
            this.title = aTitle;
            this.director = aDirector;
            this.rating = aRating;
        }
        public string Rating
        {
            get { return rating; }
            set
            {
                if (value == "G" || value == "PG" || value == "PG-13" || value == "R")
                {
                    rating = value;
                }
                else { }
                {
                    rating = "NR";
                }
            }
        }          
                
                class program
        {
            static void Main(string[] args)
            {
                {
                    movie movie1 = new movie("titanic", "Jim", "PG-13");
                    movie movie2 = new movie("Unrelease", "Sue", "PG");
                    Console.WriteLine(movie1.Rating);
                    Console.ReadLine();

                }
            }
        }
    }
}