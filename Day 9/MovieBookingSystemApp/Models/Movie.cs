using System;
using System.Collections.Generic;

namespace Models
{
    /// <summary>
    /// Represents a movie.
    /// </summary>
    public class Movie
    {
        // Properties
        public int Id { get; set; }                     // Unique identifier for the movie
        public string Title { get; set; }               // Title of the movie
        public string Genre { get; set; }               // Genre of the movie
        public int DurationMinutes { get; set; }        // Duration of the movie in minutes
        public List<DateTime> ScreeningTimes { get; set; } // List of screening times for the movie
        public decimal TicketPrice { get; set; }        // Price of a ticket for the movie

        // Default Constructor
        /// <summary>
        /// Initializes a new instance of the Movie class with default values.
        /// </summary>
        public Movie()
        {
            Id = 0;
            Title = string.Empty;
            Genre = string.Empty;
            DurationMinutes = 0;
            ScreeningTimes = new List<DateTime>();
            TicketPrice = 0;
        }

        // Parameterized Constructor
        /// <summary>
        /// Initializes a new instance of the Movie class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier for the movie.</param>
        /// <param name="title">The title of the movie.</param>
        /// <param name="genre">The genre of the movie.</param>
        /// <param name="durationMinutes">The duration of the movie in minutes.</param>
        /// <param name="screeningTimes">The list of screening times for the movie.</param>
        /// <param name="ticketPrice">The price of a ticket for the movie.</param>
        public Movie(int id, string title, string genre, int durationMinutes, List<DateTime> screeningTimes, decimal ticketPrice)
        {
            Id = id;
            Title = title;
            Genre = genre;
            DurationMinutes = durationMinutes;
            ScreeningTimes = screeningTimes;
            TicketPrice = ticketPrice;
        }

        // Method to override the ToString method to provide a string representation of the movie
        /// <summary>
        /// Overrides the ToString method to provide a string representation of the movie.
        /// </summary>
        /// <returns>A string representing the movie details.</returns>
        public override string ToString()
        {
            // Join the screening times into a single string
            string screeningTimesString = string.Join(", ", ScreeningTimes.Select(time => time.ToString("HH:mm")));

            // Return a string containing the movie details
            return $"Title: {Title}\nGenre: {Genre}\nDuration: {DurationMinutes} minutes\nScreening Times: {screeningTimesString}\nTicket Price: Rs {TicketPrice}";
        }
    }
}
