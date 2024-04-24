using System;
using System.Collections.Generic;
using DataAccessLayer;
using Models;

namespace BusinessLogicLayer
{
    public class MovieManager
    {
        private MovieRepository _movieRepository; // Instance of MovieRepository to interact with movie data

        // Constructor
        public MovieManager()
        {
            // Initialize MovieRepository instance
            _movieRepository = new MovieRepository();
        }

        // Method to get all movies
        public List<Movie> GetAllMovies()
        {
            // Delegate call to MovieRepository to retrieve all movies
            return _movieRepository.GetAllMovies();
        }

        // Method to get a movie by its ID
        public Movie GetMovieById(int id)
        {
            // Delegate call to MovieRepository to retrieve a movie by ID
            return _movieRepository.GetMovieById(id);
        }

        // Method to add a new movie
        public void AddMovie(Movie movie)
        {
            // Delegate call to MovieRepository to add a new movie
            _movieRepository.AddMovie(movie);
        }

        // Method to update an existing movie
        public void UpdateMovie(Movie updatedMovie)
        {
            // Delegate call to MovieRepository to update an existing movie
            _movieRepository.UpdateMovie(updatedMovie);
        }

        // Method to remove a movie by its ID
        public void RemoveMovie(int id)
        {
            // Delegate call to MovieRepository to remove a movie by ID
            _movieRepository.RemoveMovie(id);
        }
    }
}
