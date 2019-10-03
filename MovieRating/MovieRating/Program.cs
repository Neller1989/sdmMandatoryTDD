using System;

namespace MovieRating
{
    class Program
    {
        static void Main(string[] args)
        {
            Logic l = new Logic(@"C:\Users\Bruger\source\repos\MovieRating\MovieRating\Data\ratingsTest.txt");
            Console.WriteLine(
                l.AverageGradeOfReviewerIsGiven(1));

        }
    }
}
