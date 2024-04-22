using Models;
using System;
using System.Collections.Generic;

namespace DataAccessLayer
{
    public class MovieRepository
    {
        private List<Movie> _movies;

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
                }, 120), // Ticket price for Inception is $10
                new Movie(2, "Tik Tik Tik", "Action", 152, new List<DateTime>
                {
                    new DateTime(2024, 4, 26, 11, 0, 0),
                    new DateTime(2024, 4, 26, 16, 0, 0),
                    new DateTime(2024, 4, 26, 21, 0, 0)
                }, 160), // Ticket price for The Dark Knight is $12
                new Movie(3, "siren", "Crime", 154, new List<DateTime>
                {
                    new DateTime(2024, 4, 27, 12, 0, 0),
                    new DateTime(2024, 4, 27, 17, 0, 0),
                    new DateTime(2024, 4, 27, 22, 0, 0)
                }, 190) // Ticket price for Pulp Fiction is $8
            };
        }

        // Method to get all movies
        public List<Movie> GetAllMovies()
        {
            return _movies;
        }

        // Method to get a movie by its ID
        public Movie GetMovieById(int id)
        {
            return _movies.Find(movie => movie.Id == id);
        }

        // Method to add a new movie
        public void AddMovie(Movie movie)
        {
            _movies.Add(movie);
        }

        // Method to update an existing movie
        public void UpdateMovie(Movie updatedMovie)
        {
            int index = _movies.FindIndex(movie => movie.Id == updatedMovie.Id);
            if (index != -1)
            {
                _movies[index] = updatedMovie;
            }
        }

        // Method to remove a movie by its ID
        public void RemoveMovie(int id)
        {
            _movies.RemoveAll(movie => movie.Id == id);
        }
    }
}
