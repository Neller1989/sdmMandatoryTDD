using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace UnitTestMovieRating
{
    [TestClass]
    public class UnitTestPerformance2
    {

        readonly Logic m = new Logic(@"C:\Users\Anders\Documents\GitHub\sdmMandatoryTDD\MovieRating\MovieRating\Data\ratings.json");




        [TestMethod()]
        public void NumberOfReviewsByUser()
        {
            long timeInSec = TimeInSeconds(() => m.ReadNumberOfViewsById(1), 6);
            Assert.IsTrue(timeInSec <= 4);
        }

        [TestMethod()]
        public void AverageGradeByUser()
        {
            long timeInSec = TimeInSeconds(() => m.AverageGradeOfReviewerIsGiven(4), 6);
            Assert.IsTrue(timeInSec <= 4);
        }

        [TestMethod()]
        public void ReviewerGivenGradeOfMovie()
        {
            long timeInSec = TimeInSeconds(() => m.VotesInGivenGrade(1, 2), 6);
            Assert.IsTrue(timeInSec <= 4);
        }

        [TestMethod()]
        public void HowManyTimesMovieSeen()
        {
            long timeInSec = TimeInSeconds(() => m.HowManyHaveSeenThisMovie(1), 6);
            Assert.IsTrue(timeInSec <= 4);
        }

        [TestMethod()]
        public void AverageGradeGivenMovie()
        {
            long timeInSec = TimeInSeconds(() => m.AverageGradeOfMovie(2), 6);
            Assert.IsTrue(timeInSec <= 4);
        }

        [TestMethod()]
        public void HowManyTimesThisMovieRated()
        {
            long timeInSec = TimeInSeconds(() => m.HowManyGradesRecievedInGivenMovie(1, 4), 6);
            Assert.IsTrue(timeInSec <= 4);
        }



        public long TimeInSeconds(Action ac, int repeats)
        {
            long time = 0;
            for (int i = 0; i < repeats; i++)
            {
                Stopwatch sWatch = new Stopwatch();
                sWatch.Start();
                ac.Invoke();
                sWatch.Stop();
                time += sWatch.ElapsedMilliseconds;

            }
            return (time / repeats) / 1000;
        }

    }
}
