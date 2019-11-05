using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating;

namespace UnitTestMovieRating
{
    [TestClass]
    public class UnitTest1
    {
        readonly Logic m = new Logic(@"Data\ratingsTest1.json");

        //opgave 1
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

        //opgave 2
        [DataRow(1, 4.25)]
        [DataRow(2, 3.75)]
        [DataTestMethod]
        public void AverageGradeByUser(int id, double act)
        {
            Assert.AreEqual(m.AverageGradeOfReviewerIsGiven(id), act);
        }

        [DataRow(1, 5)]
        [DataRow(2, 4)]
        [DataTestMethod]
        public void AverageGradeByUser2(int id, double act)
        {
            Assert.AreNotEqual(m.AverageGradeOfReviewerIsGiven(id), act);
        }

        //opgave 3
        [DataRow(2, 4, 2)]
        [DataTestMethod]
        public void ReviewerGivenGradeOfMovie(int id, int grade, int exp)
        {
            Assert.AreEqual(m.VotesInGivenGrade(id, grade), exp);
        }

        [DataRow(2, 4, 5)]
        [DataTestMethod]
        public void ReviewerGivenGradeOfMovie2(int id, int grade, int exp)
        {
            Assert.AreNotEqual(m.VotesInGivenGrade(id, grade), exp);
        }

        //opgave 4
        [DataRow(30878, 3)]
        [DataRow(1488844, 1)]
        [DataTestMethod]
        public void HowManyTimesMovieSeen(int movieId, int exp)
        {
            Assert.AreEqual(m.HowManyHaveSeenThisMovie(movieId), exp);
        }

        [DataRow(30878, 5)]
        [DataRow(1488844, 9)]
        [DataTestMethod]
        public void HowManyTimesMovieSeen2(int movieId, int exp)
        {
            Assert.AreNotEqual(m.HowManyHaveSeenThisMovie(movieId), exp);
        }

        //opgave 5
        [DataRow(30878, 5)]
        [DataRow(1488844, 3)]
        [DataTestMethod]
        public void AverageGradeGivenMovie(int movieId, double exp)
        {
            Assert.AreEqual(m.AverageGradeOfMovie(movieId), exp);
        }

        [DataRow(30878, 15)]
        [DataRow(1488844, 30)]
        [DataTestMethod]
        public void AverageGradeGivenMovie2(int movieId, double exp)
        {
            Assert.AreNotEqual(m.AverageGradeOfMovie(movieId), exp);
        }

        //opgave 6
        [DataRow(30878, 5, 3)]
        [DataRow(822109, 5, 1)]
        [DataTestMethod]
        public void HowManyTimesThisMovieRated(int movieId, int grade, int exp)
        {
            Assert.AreEqual(m.HowManyGradesRecievedInGivenMovie(movieId, grade), exp);
        }

        /* opgave 7 (der bliver printet antal ud som er i listen. men metoden selv printer
        alle film id'er ud samt hvis der er duplicated movieId'er bliver disse fjernet så der kun er
        1 enkelt eksemplar ) */
        [DataRow(3)]
        [DataTestMethod]
        public void TopRatedMovies(int exp)
        {
            int numbers = 0;
            foreach (var item in m.TopRatedMovies())
            {
                numbers++;
            }

            Assert.AreEqual(numbers, exp);
        }

    }
}
