using System;
using System.Collections.Generic;

namespace Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }
        public int DurationMinutes { get; set; }
        public List<DateTime> ScreeningTimes { get; set; } // List of screening times
        public decimal TicketPrice { get; set; } // Ticket price

        public Movie()
        {
            Id = 0;
            Title = string.Empty;
            Genre = string.Empty;
            DurationMinutes = 0;
            ScreeningTimes = new List<DateTime>();
            TicketPrice = 0;
        }

        public Movie(int id, string title, string genre, int durationMinutes, List<DateTime> screeningTimes, decimal ticketPrice)
        {
            Id = id;
            Title = title;
            Genre = genre;
            DurationMinutes = durationMinutes;
            ScreeningTimes = screeningTimes;
            TicketPrice = ticketPrice;
        }

        public override string ToString()
        {
            return $"Title: {Title}\nGenre: {Genre}\nDuration: {DurationMinutes} minutes\nScreening Times: {string.Join(", ", ScreeningTimes.Select(time => time.ToString("HH:mm")))}\nTicket Price: Rs {TicketPrice}";
        }


    }
}
