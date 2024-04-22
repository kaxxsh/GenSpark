using Models;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    /// <summary>
    /// Repository class for managing movies.
    /// </summary>
    public class MovieRepository
    {
        private List<Movie> _movies;

        /// <summary>
        /// Initializes a new instance of the MovieRepository class and populates it with sample movie data.
        /// </summary>
        public MovieRepository()
        {
            // Initialize the list of movies with sample data including ticket prices
            _movies = new List<Movie>
            {
                new Movie(1, "2.0", "Sci-Fi", 150, new List<DateTime>
                {
                    new DateTime(2024, 4, 25, 10, 0, 0),
                    new DateTime(2024, 4, 25, 15, 0, 0),
                    new DateTime(2024, 4, 25, 20, 0, 0)
                }, 120), // Ticket price for 2.0 is $10
                new Movie(2, "Tik Tik Tik", "Action", 152, new List<DateTime>
                {
                    new DateTime(2024, 4, 26, 11, 0, 0),
                    new DateTime(2024, 4, 26, 16, 0, 0),
                    new DateTime(2024, 4, 26, 21, 0, 0)
                }, 160), // Ticket price for Tik Tik Tik is $12
                new Movie(3, "siren", "Crime", 154, new List<DateTime>
                {
                    new DateTime(2024, 4, 27, 12, 0, 0),
                    new DateTime(2024, 4, 27, 17, 0, 0),
                    new DateTime(2024, 4, 27, 22, 0, 0)
                }, 190), // Ticket price for siren is $8
                // Additional Tamil movies
                new Movie(4, "Kaithi", "Action", 146, new List<DateTime>
                {
                    new DateTime(2024, 4, 28, 11, 0, 0),
                    new DateTime(2024, 4, 28, 15, 0, 0),
                    new DateTime(2024, 4, 28, 19, 0, 0)
                }, 150), // Ticket price for Kaithi is $12
                new Movie(5, "Vada Chennai", "Crime", 180, new List<DateTime>
                {
                    new DateTime(2024, 4, 29, 10, 0, 0),
                    new DateTime(2024, 4, 29, 14, 0, 0),
                    new DateTime(2024, 4, 29, 18, 0, 0)
                }, 170) // Ticket price for Vada Chennai is $10
            };
        }

        /// <summary>
        /// Retrieves all movies.
        /// </summary>
        /// <returns>A list of all movies.</returns>
        public List<Movie> GetAllMovies()
        {
            return _movies;
        }

        /// <summary>
        /// Retrieves a movie by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie to retrieve.</param>
        /// <returns>The movie with the specified ID, or null if not found.</returns>
        public Movie GetMovieById(int id)
        {
            return _movies.Find(movie => movie.Id == id);
        }

        /// <summary>
        /// Adds a new movie to the repository.
        /// </summary>
        /// <param name="movie">The movie to add.</param>
        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        /// <summary>
        /// Updates an existing movie in the repository.
        /// </summary>
        /// <param name="updatedMovie">The updated movie information.</param>
        public void UpdateMovie(Movie updatedMovie)
        {
            int index = _movies.FindIndex(movie => movie.Id == updatedMovie.Id);
            if (index != -1)
            {
                _movies[index] = updatedMovie;
            }
        }

        /// <summary>
        /// Removes a movie from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the movie to remove.</param>
        public void RemoveMovie(int id)
        {
            _movies.RemoveAll(movie => movie.Id == id);
        }
    }
}
