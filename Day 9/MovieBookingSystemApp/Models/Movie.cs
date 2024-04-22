using System;
using System.Collections.Generic;

namespace Models
{
    public class Movie
    {
        // Properties
        public int Id { get; set; } // Unique identifier of the movie
        public string Title { get; set; } // Title of the movie
        public string Genre { get; set; } // Genre of the movie
        public int DurationMinutes { get; set; } // Duration of the movie in minutes
        public List<DateTime> ScreeningTimes { get; set; } // List of screening times for the movie
        public decimal TicketPrice { get; set; } // Price of a ticket for the movie

        // Default constructor
        public Movie()
        {
            // Initialize properties with default values
            Id = 0;
            Title = string.Empty;
            Genre = string.Empty;
            DurationMinutes = 0;
            ScreeningTimes = new List<DateTime>();
            TicketPrice = 0;
        }

        // Parameterized constructor
        public Movie(int id, string title, string genre, int durationMinutes, List<DateTime> screeningTimes, decimal ticketPrice)
        {
            // Initialize properties with provided values
            Id = id;
            Title = title;
            Genre = genre;
            DurationMinutes = durationMinutes;
            ScreeningTimes = screeningTimes;
            TicketPrice = ticketPrice;
        }

        // Override ToString() method to provide string representation of the movie object
        public override string ToString()
        {
            // Format movie details including title, genre, duration, screening times, and ticket price
            return $"Title: {Title}\nGenre: {Genre}\nDuration: {DurationMinutes} minutes\nScreening Times: {string.Join(", ", ScreeningTimes.Select(time => time.ToString("HH:mm")))}\nTicket Price: Rs {TicketPrice}";
        }
    }
}
