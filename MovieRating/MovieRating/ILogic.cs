using System.Collections.Generic;

namespace MovieRating
{
    public interface ILogic
    {
        //opgave 1
        //On input N, what are the number of reviews from reviewer N?
        int ReadNumberOfViewsById(int id);

        //opgave 2
        //On input N, what is the average rate that reviewer N had given?
        double AverageGradeOfReviewerIsGiven(int id);

        //opgave 3
        //On input N and G, how many times has reviewer N given a movie grade G?
        int VotesInGivenGrade(int grade, int id);

        //opgave 4
        //On input N, how many have reviewed movie N?
        int HowManyHaveSeenThisMovie(int movieId);

        //opgave 5
        //On input N, what is the average rate the movie N had received?
        double AverageGradeOfMovie(int movieId);

        //opgave 6
        //On input N and G, how many times had movie N received grade G?
        int HowManyGradesRecievedInGivenMovie(int movieId, int givenGrade);

        //opgave 7
        //What is the id(s) of the movie(s) with the highest number of top rates(5)?
        List<int> TopRatedMovies();

        //opgave 8
        //What reviewer(s) had done most reviews?
        int TopViewerHowMany(int id);

        //opgave 9 forstår ikke rigtig
        //On input N, what is top N of movies? The score of a movie is its average rate.
        int TopMovieAverage(int movieId);

        //opgave 10
        //On input N, what are the movies that reviewer N has reviewed? The list should be sorted decreasing by rate first, and date secondly.
        int WhatMovieReviewsLastSeenDec(int id);

        //opgave 11
        //On input N, what are the reviewers that have reviewed movie N? The list should be sorted decreasing by rate first, and date secondly.
        int MovieReviewerHasSeenDec(int movieId);

    }
}
