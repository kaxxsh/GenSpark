using System;
using System.Collections.Generic;
using DataAccessLayer;
using Models;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Manages movie-related operations by interacting with the MovieRepository.
    /// </summary>
    public class MovieManager
    {
        private MovieRepository _movieRepository;

        /// <summary>
        /// Initializes a new instance of the MovieManager class.
        /// </summary>
        public MovieManager()
        {
            _movieRepository = new MovieRepository();
        }

        /// <summary>
        /// Retrieves all movies.
        /// </summary>
        /// <returns>A list of all movies.</returns>
        public List<Movie> GetAllMovies()
        {
            return _movieRepository.GetAllMovies();
        }

        /// <summary>
        /// Retrieves a movie by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie to retrieve.</param>
        /// <returns>The movie with the specified ID.</returns>
        public Movie GetMovieById(int id)
        {
            return _movieRepository.GetMovieById(id);
        }

        /// <summary>
        /// Adds a new movie.
        /// </summary>
        /// <param name="movie">The movie to add.</param>
        public void AddMovie(Movie movie)
        {
            _movieRepository.AddMovie(movie);
        }

        /// <summary>
        /// Updates an existing movie.
        /// </summary>
        /// <param name="updatedMovie">The updated movie object.</param>
        public void UpdateMovie(Movie updatedMovie)
        {
            _movieRepository.UpdateMovie(updatedMovie);
        }

        /// <summary>
        /// Removes a movie by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie to remove.</param>
        public void RemoveMovie(int id)
        {
            _movieRepository.RemoveMovie(id);
        }
    }
}
