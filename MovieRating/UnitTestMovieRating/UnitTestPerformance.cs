﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        private static LogicOpt m = new LogicOpt(@"C:\Users\nikla\Documents\GitHub\sdmMandatoryTDD\MovieRating\MovieRating\Data\ratings.json");

        private readonly int MOVIEID = 1488844;
        private readonly int REVIEWERID = 1;

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
        public void Opgave1()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.ReadNumberOfViewsById(REVIEWERID);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= 4);
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

                Assert.IsTrue(time <= 4);
            }
        }

        [TestMethod]
        public void Opgave3()
        {
            for (int i = 1; i <= 5; i++)
            {
                Stopwatch sw = Stopwatch.StartNew();
                m.VotesInGivenGrade(REVIEWERID, 5);
                sw.Stop();
                double time = sw.ElapsedMilliseconds / 1000.0;

                Assert.IsTrue(time <= 4);
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


                Assert.IsTrue(time <= 4);
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


                Assert.IsTrue(time <= 4);
            }
        }

    }
}
