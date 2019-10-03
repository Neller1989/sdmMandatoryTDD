using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating;

namespace UnitTestMovieRating
{
    [TestClass]
    public class UnitTest1
    {
        //C:/Users/Bruger/source/repos/MovieRating/MovieRating/Data/ratingsTest1.json
        readonly Logic m = new Logic(@"C:\Users\Anders\Documents\GitHub\sdmMandatoryTDD\MovieRating\MovieRating\Data\ratingsTest1.json");


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

        [DataRow(1, 4)]
        [DataRow(2, 3.75)]
        [DataTestMethod]
        public void AverageGradeByUser(int id, double act)
        {
            Assert.AreEqual(m.AverageGradeOfReviewerIsGiven(id), act);
        }
        [DataRow(1, 4)]
        [DataRow(2, 4)]
        [DataRow(4, 3)]
        [DataTestMethod]
        public void MoviesWithSameGrade(int id, int grade)
        {
            var count = m.VotesInGivenGrade(grade, id);
            //Assert.AreEqual(count);
        }
    
        [TestMethod]
        public void HowManyTimesMovieSeen()
        {

        }

        [TestMethod]
        public void AverageGradeGivenMovie()
        {
        }

        [TestMethod]
        public void HowManyTimesThisMovieRated()
        {
        }


}
}
