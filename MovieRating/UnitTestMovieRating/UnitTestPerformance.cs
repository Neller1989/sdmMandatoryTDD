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

        private static LogicOpt m = new LogicOpt(@"Data\ratingsTest1.json");

        private readonly int MOVIEID = 1488844;
        private readonly int REVIEWERID = 1;
        private readonly int GRADETOTEST = 3;
        private readonly int TIMETOPASS = 4;
        private readonly double TIMETOFAIL = 0.00001; 

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
                m.ReadNumberOfViewsById(REVIEWERID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIMETOFAIL);
            }
        }

        [TestMethod]
        public void Opgave1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.ReadNumberOfViewsById(REVIEWERID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIMETOPASS);
            }
        }

        [TestMethod]
        public void Opgave2()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.AverageGradeOfReviewerIsGiven(REVIEWERID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIMETOPASS);
            }
        }

        [TestMethod]
        public void Opgave3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.VotesInGivenGrade(GRADETOTEST, REVIEWERID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= TIMETOPASS);
            }
        }

        [TestMethod]
        public void Opgave4()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                m.HowManyHaveSeenThisMovie(MOVIEID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.IsTrue(time <= TIMETOPASS);
            }
        }

        [TestMethod]
        public void Opgave5()
        {
            for (int i = 1; i <= 5; i++)
            {

                Stopwatch sw = Stopwatch.StartNew();
                m.AverageGradeOfMovie(MOVIEID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;


                Assert.IsTrue(time <= TIMETOPASS);
            }
        }

    }
}
