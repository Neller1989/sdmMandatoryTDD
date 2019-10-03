using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            //@"C:\Users\Bruger\source\repos\MovieRating\MovieRating\Data\ratingsTest.txt"
            Logic l = new Logic(@"C:\Users\nikla\Documents\GitHub\sdmMandatoryTDD\MovieRating\MovieRating\Data\ratingsTest1.json");
            Console.WriteLine(
                l.VotesInGivenGrade(2,4));

        }
    }
}
