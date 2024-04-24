using System;

namespace Models
{
    public class Booking
    {
        public int Id { get; set; }                     // Unique identifier for the booking
        public int MovieId { get; set; }                // ID of the booked movie
        public DateTime ScreeningTime { get; set; }     // Timing of the screening
        public int NumberOfTickets { get; set; }        // Number of tickets booked
        public string CustomerName { get; set; }        // Name of the customer
        public string ContactInfo { get; set; }         // Contact information of the customer

        // Default Constructor
        public Booking()
        {
            // Initialize properties
            Id = 0;
            MovieId = 0;
            ScreeningTime = DateTime.MinValue;
            NumberOfTickets = 0;
            CustomerName = string.Empty;
            ContactInfo = string.Empty;
        }

        // Parameterized Constructor
        public Booking(int id, int movieId, DateTime screeningTime, int numberOfTickets, string customerName, string contactInfo)
        {
            Id = id;
            MovieId = movieId;
            ScreeningTime = screeningTime;
            NumberOfTickets = numberOfTickets;
            CustomerName = customerName;
            ContactInfo = contactInfo;
        }

        // Method to override the ToString method to provide a string representation of the booking
        public override string ToString()
        {
            return $"Booking ID: {Id}\nMovie ID: {MovieId}\nScreening Time: {ScreeningTime}\nNumber of Tickets: {NumberOfTickets}\nCustomer Name: {CustomerName}\nContact Info: {ContactInfo}";
        }
    }
}
