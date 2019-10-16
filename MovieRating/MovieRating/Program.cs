using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            //@"C:\Users\Bruger\source\repos\MovieRating\MovieRating\Data\ratingsTest.txt"
            Logic l = new Logic(@"C:\Users\nikla\Documents\GitHub\sdmMandatoryTDD\MovieRating\MovieRating\Data\ratings.json");


            Console.Write("Film med 5 stjerner : ");
            foreach (var item in l.TopRatedMovies())
            {
                Console.Write(item + "    ");
            }
            

        }
    }
}
