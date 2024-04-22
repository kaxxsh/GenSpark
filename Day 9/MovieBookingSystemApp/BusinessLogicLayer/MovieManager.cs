using System;
using System.Collections.Generic;
using DataAccessLayer;
using Models;

namespace BusinessLogicLayer
{
    public class MovieManager
    {
        private MovieRepository _movieRepository;

        public MovieManager()
        {
            _movieRepository = new MovieRepository();
        }

        // Method to get all movies
        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        // Method to get a movie by its ID
        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

        // Method to add a new movie
        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        // Method to update an existing movie
        public void UpdateMovie(Movie updatedMovie)
        {
            _movieRepository.UpdateMovie(updatedMovie);
        }

        // Method to remove a movie by its ID
        public void RemoveMovie(int id)
        {
            _movieRepository.RemoveMovie(id);
        }
    }
}
