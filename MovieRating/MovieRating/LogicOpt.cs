using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace MovieRating
{
    public class LogicOpt : ILogic
    {
        List<Rating> movieRating;

        public LogicOpt(string fileName)
        {
            using (StreamReader sr = new StreamReader(fileName))
            {
                string j = sr.ReadToEnd();
                movieRating = JsonConvert.DeserializeObject<List<Rating>>(j);
            }
        }

        //opgave1
        public int ReadNumberOfViewsById(int id)
        {
            int viewer = 0;
            
            foreach (var movie in movieRating)
            {
                if (movie.Reviewer == id)
                {
                    viewer++;
                }
            }

            return viewer;
        }

        //opgave2
        public double AverageGradeOfReviewerIsGiven(int id)
        {
            double sum = 0.0;
            double antal = 0;

            foreach (var rating in movieRating)
            {
                antal++;
                sum += rating.Grade;
            }

            return sum / antal;
        }

        //opgave 3
        public int VotesInGivenGrade(int grade, int id)
        {
            int grades = 0;

            foreach (var movie in movieRating)
            {
                if (movie.Grade == grade && movie.Reviewer == id)
                {
                    grades++;
                }
            }
            if (grades == 0)
            {
                throw new InvalidDataException("Der blev ikke fundet noget med denne id eller karakter");
            }

            return grades;
        }

        //opgave 4
        public int HowManyHaveSeenThisMovie(int movieId)
        {
            int antal = 0;

            foreach (var movie in movieRating)
            {
                if (movie.Movie == movieId)
                {
                    antal++;
                }
            }
            if (antal == 0)
            {
                throw new InvalidDataException("Der blev ikke fundet noget med denne id eller karakter.");
            }

            return antal;
        }

        //opgave5
        public double AverageGradeOfMovie(int movieId)
        {
            double sum = 0;
            double antal = 0;

            foreach (var movie in movieRating)
            {
                if (movie.Movie == movieId)
                {
                    antal++;
                    sum = sum + movie.Grade;
                }
            }
            if (sum == 0)
            {
                throw new InvalidDataException("Der blev ikke fundet noget med denne id eller karakter");
            }

            return sum / antal;
        }

        
        //opgave 6
        public int HowManyGradesRecievedInGivenMovie(int movieId, int givenGrade)
        {
            int antal = 0;

            foreach (var movie in movieRating)
            {
                if (movie.Movie == movieId && movie.Grade == givenGrade)
                {
                    antal++;
                }
            }
            if (antal == 0)
            {
                throw new InvalidDataException("Der blev ikke fundet noget med denne id eller karakter");
            }
            return antal;
        }

        

        public int MovieReviewerHasSeenDec(int movieId)
        {
            throw new NotImplementedException();
        }

        

        public int TopMovieAverage(int movieId)
        {
            throw new NotImplementedException();
        }

        public List<int> TopRatedMovies()
        {
            throw new NotImplementedException();
        }

        public int TopViewerHowMany(int id)
        {
            throw new NotImplementedException();
        }

        

        public int WhatMovieReviewsLastSeenDec(int id)
        {
            throw new NotImplementedException();
        }
    }
}
