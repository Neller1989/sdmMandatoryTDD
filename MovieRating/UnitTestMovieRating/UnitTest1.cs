using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating;

namespace UnitTestMovieRating
{
    [TestClass]
    public class UnitTest1
    {
        readonly Logic m = new Logic(@"C:\Users\nikla\Documents\GitHub\sdmMandatoryTDD\MovieRating\MovieRating\Data\ratingsTest1.json");


        [DataRow(1, 4)]
        [DataRow(2, 4)]
        [DataRow(3, 3)]
        [DataRow(4, 4)]
        [DataTestMethod]
        public void NumberOfReviewsByUser(int id, int act)
        {
            var ratings = m.ReadNumberOfViewsById(id);
            Assert.AreEqual(ratings, act);
        }

        [DataRow(1, 4.25)]
        [DataRow(2, 3.75)]
        [DataTestMethod]
        public void AverageGradeByUser(int id, double act)
        {
            Assert.AreEqual(m.AverageGradeOfReviewerIsGiven(id), act);
        }
        
        [TestMethod]
        public void MoviesWithSameGrade()
        {
            int id = 2;
            int grade = 4;
            Assert.AreEqual(m.VotesInGivenGrade(id, grade), 2);
        }

        [DataRow(30878, 3)]
        [DataRow(1488844, 1)]
        [DataTestMethod]
        public void HowManyTimesMovieSeen(int movieId, int exp)
        {
            Assert.AreEqual(m.HowManyHaveSeenThisMovie(movieId), exp);
        }

        [DataRow(30878, 5)]
        [DataRow(1488844, 3)]
        [DataTestMethod]
        public void AverageGradeGivenMovie(int movieId, double exp)
        {
            Assert.AreEqual(m.AverageGradeOfMovie(movieId), exp);
        }

        [TestMethod]
        public void HowManyTimesThisMovieRated()
        {
        }


}
}
