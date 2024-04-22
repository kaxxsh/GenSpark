using System;

namespace Models
{
    public class Booking
    {
        // Properties
        public int Id { get; set; } // Unique identifier of the booking
        public int MovieId { get; set; } // ID of the movie booked
        public DateTime ScreeningTime { get; set; } // Screening time of the booked movie
        public int NumberOfTickets { get; set; } // Number of tickets booked
        public string CustomerName { get; set; } // Name of the customer who booked
        public string ContactInfo { get; set; } // Contact information of the customer who booked

        // Constructor
        public Booking(int id, int movieId, DateTime screeningTime, int numberOfTickets, string customerName, string contactInfo)
        {
            // Initialize properties with provided values
            Id = id;
            MovieId = movieId;
            ScreeningTime = screeningTime;
            NumberOfTickets = numberOfTickets;
            CustomerName = customerName;
            ContactInfo = contactInfo;
        }

        // Override ToString method to provide a string representation of the object
        public override string ToString()
        {
            // Format booking details including ID, movie ID, screening time, number of tickets, customer name, and contact information
            return $"Booking ID: {Id}\nMovie ID: {MovieId}\nScreening Time: {ScreeningTime}\nNumber of Tickets: {NumberOfTickets}\nCustomer Name: {CustomerName}\nContact Info: {ContactInfo}\n";
        }
    }
}
