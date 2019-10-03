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

                foreach (var item in movieRating)
                {
                    Console.WriteLine("{0} : Reviewer ,  {1} : MovieId ,  {2} : Rating ,  {3} : DateTime" , item.Reviewer , item.Movie, item.Grade , item.Date ) ;
                }

            }/*

            //Skal finde ud af hvad der sker ud? og den ikke virker senere
            using (StreamReader file = new StreamReader(fileName)) 
            using (JsonTextReader reader = new JsonTextReader(file))
            {
                reader.SupportMultipleContent = true;

                var serializer = new JsonSerializer();
                while (reader.Read())
                {
                    if (reader.TokenType == JsonToken.StartObject)
                    {
                        Rating r = serializer.Deserialize<Rating>(reader);

                        Console.WriteLine("movie : " + r.Movie + " reviewer : " + r.Reviewer + " Grade: " + r.Grade + " Date :" + r.Date);
                        Console.WriteLine("1");
                    }
                }
            }
            /*
            //ny metode som ikke virker

            JArray movieToken = JArray.Parse(fileName);

            movieRating = movieToken.Select(p => new Rating
            {
                Reviewer = (int)p["Reviewer"],
                Movie = (int)p["Movies"],
                Grade = (int)p["Grade"],
                //Movie = p["Movies"].Select(t => (float)t).ToList(),
                //Grade = p["Grade"].Select(t => (int)t).ToList(),
                Date = (DateTime)p["Date"]
            }).ToList();

            foreach (var item in movieRating)
            {
                Console.WriteLine("" + item);
                Console.WriteLine("2");
            }*/

        }

        //opgave 1
        public int ReadNumberOfViewsById(int id)
        {
            List<Rating> movies = new List<Rating>();
            movies = movieRating.Where(p => p.Reviewer == id).ToList();
            return movies.Count;
        }

        //opgave 2
        public double AverageGradeOfReviewerIsGiven(int id)
        {
            List<Rating> avgGrade = new List<Rating>();
            avgGrade = movieRating.Where(p => p.Reviewer == id ).ToList();
            var result = avgGrade.Select(p => p.Grade).Average();

            return result;    
        }

        //opgave 3
        public int VotesInGivenGrade(int grade, int id)
        {
            throw new NotImplementedException();
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
            throw new NotImplementedException();
        }

        //opgave 7
        public int TopRatedMovies(int movieId)
        {
            throw new NotImplementedException();
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
