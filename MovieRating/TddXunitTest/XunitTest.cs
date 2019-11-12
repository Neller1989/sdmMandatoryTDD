using MovieRating;
using System;
using Xunit;

namespace TddXunitTest
{
    public class UnitTest1
    {
        readonly Logic m = new Logic(@"..\..\..\ratingsTest1.json");

        //opgave 1
        [Theory]
        [InlineData(1, 4)]
        [InlineData(2, 4)]
        [InlineData(3, 3)]
        [InlineData(4, 4)]
        public void NumberOfReviewsByUser(int id, int act)
        {
            var ratings = m.ReadNumberOfViewsById(id);
            Assert.Equal(ratings, act);
        }

        //opgave 2
        [Theory]
        [InlineData(1, 4.25)]
        [InlineData(2, 3.75)]
        public void AverageGradeByUser(int id, double act)
        {
            Assert.Equal(m.AverageGradeOfReviewerIsGiven(id), act);
        }

        [Theory]
        [InlineData(1, 5)]
        [InlineData(2, 4)]
        public void AverageGradeByUser2(int id, double act)
        {
            Assert.NotEqual(m.AverageGradeOfReviewerIsGiven(id), act);
        }

        //opgave 3
        [Theory]
        [InlineData(2, 4, 2)]
        public void ReviewerGivenGradeOfMovie(int id, int grade, int exp)
        {
            Assert.Equal(m.VotesInGivenGrade(id, grade), exp);
        }

        [Theory]
        [InlineData(2, 4, 5)]
        public void ReviewerGivenGradeOfMovie2(int id, int grade, int exp)
        {
            Assert.NotEqual(m.VotesInGivenGrade(id, grade), exp);
        }

        //opgave 4
        [Theory]
        [InlineData(30878, 3)]
        [InlineData(1488844, 1)]
        public void HowManyTimesMovieSeen(int movieId, int exp)
        {
            Assert.Equal(m.HowManyHaveSeenThisMovie(movieId), exp);
        }

        [Theory]
        [InlineData(30878, 5)]
        [InlineData(1488844, 9)]
        public void HowManyTimesMovieSeen2(int movieId, int exp)
        {
            Assert.NotEqual(m.HowManyHaveSeenThisMovie(movieId), exp);
        }

        //opgave 5
        [Theory]
        [InlineData(30878, 5)]
        [InlineData(1488844, 3)]
        public void AverageGradeGivenMovie(int movieId, double exp)
        {
            Assert.Equal(m.AverageGradeOfMovie(movieId), exp);
        }

        [Theory]
        [InlineData(30878, 15)]
        [InlineData(1488844, 30)]
        public void AverageGradeGivenMovie2(int movieId, double exp)
        {
            Assert.NotEqual(m.AverageGradeOfMovie(movieId), exp);
        }

        //opgave 6
        [Theory]
        [InlineData(30878, 5, 3)]
        [InlineData(822109, 5, 1)]
        public void HowManyTimesThisMovieRated(int movieId, int grade, int exp)
        {
            Assert.Equal(m.HowManyGradesRecievedInGivenMovie(movieId, grade), exp);
        }

        /* opgave 7 (der bliver printet antal ud som er i listen. men metoden selv printer
        alle film id'er ud samt hvis der er duplicated movieId'er bliver disse fjernet så der kun er
        1 enkelt eksemplar ) */
        [Theory]
        [InlineData(3)]
        public void TopRatedMovies(int exp)
        {
            int numbers = 0;
            foreach (var item in m.TopRatedMovies())
            {
                numbers++;
            }

            Assert.Equal(numbers, exp);
        }
        [Fact]
        public void Test1()
        {

        }
    }
}
