using Microsoft.VisualStudio.TestTools.UnitTesting;
using MovieRating;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace UnitTestMovieRating
{
    [TestClass]
    public class UnitTestPerformance
    {
        private static LogicOpt m = new LogicOpt(@"..\..\..\ratingsTest1.json");

        private readonly int MOVIE_ID = 1488844;
        private readonly int REVIEWER_ID = 1;
        private readonly int GRADE_TO_TEST = 3;
        private readonly int TIME_TO_PASS = 4;
        private readonly double TIME_TO_FAIL = 45; 

        private double getAverageTime(Action ac, int repeats)
        {
            double sum = 0;

            for (int i = 0; i < repeats; i++)
            {
                Stopwatch sw = new Stopwatch();
                sw.Start();
                ac.Invoke();
                sw.Stop();
                sum += sw.ElapsedMilliseconds;
            }
            return (sum / (double)repeats) / 1000.0;
        }


        [TestMethod]
        public void LadDenLæse()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.ReadNumberOfViewsById(REVIEWER_ID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIME_TO_FAIL);
            }
        }

        [TestMethod]
        public void Opgave1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.ReadNumberOfViewsById(REVIEWER_ID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIME_TO_PASS);
            }
        }

        [TestMethod]
        public void Opgave2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.AverageGradeOfReviewerIsGiven(REVIEWER_ID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIME_TO_PASS);
            }
        }

        [TestMethod]
        public void Opgave3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.VotesInGivenGrade(GRADE_TO_TEST, REVIEWER_ID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIME_TO_PASS);
            }
        }

        [TestMethod]
        public void Opgave4()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                m.HowManyHaveSeenThisMovie(MOVIE_ID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.IsTrue(time <= TIME_TO_PASS);
            }
        }

        [TestMethod]
        public void Opgave5()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                m.AverageGradeOfMovie(MOVIE_ID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.IsTrue(time <= TIME_TO_PASS);
            }
        }

    }
}
