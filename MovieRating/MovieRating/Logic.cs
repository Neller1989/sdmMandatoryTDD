using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MovieRating
{
    public class Logic : ILogic
    {
        public IEnumerable<Rating> movieRating;

        public Logic(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string j = sr.ReadToEnd();
                movieRating = JsonConvert.DeserializeObject<IEnumerable<Rating>>(j);

                //foreach (var item in movieRating)
                //{
                //    Console.WriteLine("{0} : Reviewer ,  {1} : MovieId ,  {2} : Rating ,  {3} : DateTime" , item.Reviewer , item.Movie, item.Grade , item.Date ) ;
                //}

            }

            

        }

        //opgave 1
        public int ReadNumberOfViewsById(int id)
        {
            List<Rating> movies = new List<Rating>();
            movies = movieRating.Where(p => p.Reviewer == id).ToList();
            //return movies.Count;

            int rev = 0;
            foreach (Rating movie in movies)
            {
                if (movie.Reviewer == id)
                {
                    rev++;
                }
            }
            if (rev == 0)
            {
                throw new InvalidDataException("Reviewer not found");
            }
            else
            {
                return rev;
            }

        }


        //opgave 2
        public double AverageGradeOfReviewerIsGiven(int id)
        {
            List<Rating> avgGrade = new List<Rating>();
            avgGrade = movieRating.Where(p => p.Reviewer == id ).ToList();
            double result = avgGrade.Select(p => p.Grade).Average();

            return result;
        }

        //opgave 3
        public int VotesInGivenGrade(int id, int grade)
        {
            List<Rating> reviewer = new List<Rating>();
            reviewer = movieRating.Where(p => p.Reviewer == id && p.Grade == grade).ToList();
            var result = reviewer.Select(p => p.Grade).Count();

            return result;
        }

        //opgave 4
        public int HowManyHaveSeenThisMovie(int movieId)
        {
            List<Rating> seen = new List<Rating>();
            seen = movieRating.Where(p => p.Movie == movieId).ToList();
            var result = seen.Select(p => p.Grade).Count();

            return result;
        }

        //opgave 5
        public double AverageGradeOfMovie(int movieId)
        {
            List<Rating> seen = new List<Rating>();
            seen = movieRating.Where(p => p.Movie == movieId).ToList();
            double result = seen.Select(p => p.Grade).Average();

            return result;
        }

        //opgave 6
        public int HowManyGradesRecievedInGivenMovie(int movieId, int givenGrade)
        {
            List<Rating> gm = new List<Rating>();
            gm = movieRating.Where(p => p.Movie == movieId && p.Grade == givenGrade).ToList();
            var result = gm.Select(p => p.Grade).Count();

            return result;
        }

        //opgave 7
        public List<int> TopRatedMovies()
        {
            List<Rating> tm = new List<Rating>();
            List<int> result = new List<int>();
            tm = movieRating.Where(p => p.Grade == 5).ToList();
            result = tm.Select(p => p.Movie).Distinct().ToList();

            return result;
        }

        //opgave 8
        public int TopViewerHowMany(int id)
        {
            throw new NotImplementedException();
        }

        //opgave 9
        public int TopMovieAverage(int movieId)
        {
            throw new NotImplementedException();
        }

        //opgave 10
        public int WhatMovieReviewsLastSeenDec(int id)
        {
            throw new NotImplementedException();
        }

        //opgave 11
        public int MovieReviewerHasSeenDec(int movieId)
        {
            throw new NotImplementedException();
        }











    }
}
