using System;

namespace Models
{
    /// <summary>
    /// Represents a booking made by a customer for a movie screening.
    /// </summary>
    public class Booking
    {
        // Properties
        public int Id { get; set; }             // Unique identifier for the booking
        public int MovieId { get; set; }        // ID of the movie being booked
        public DateTime ScreeningTime { get; set; }   // Date and time of the movie screening
        public int NumberOfTickets { get; set; }      // Number of tickets booked
        public string CustomerName { get; set; }      // Name of the customer
        public string ContactInfo { get; set; }       // Contact information of the customer

        /// <summary>
        /// Initializes a new instance of the Booking class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier for the booking.</param>
        /// <param name="movieId">The ID of the movie being booked.</param>
        /// <param name="screeningTime">The date and time of the movie screening.</param>
        /// <param name="numberOfTickets">The number of tickets booked.</param>
        /// <param name="customerName">The name of the customer.</param>
        /// <param name="contactInfo">The contact information of the customer.</param>
        public Booking(int id, int movieId, DateTime screeningTime, int numberOfTickets, string customerName, string contactInfo)
        {
            Id = id;
            MovieId = movieId;
            ScreeningTime = screeningTime;
            NumberOfTickets = numberOfTickets;
            CustomerName = customerName;
            ContactInfo = contactInfo;
        }

        /// <summary>
        /// Overrides the ToString method to provide a string representation of the booking object.
        /// </summary>
        /// <returns>A string representing the booking details.</returns>
        public override string ToString()
        {
            return $"Booking ID: {Id}\nMovie ID: {MovieId}\nScreening Time: {ScreeningTime}\nNumber of Tickets: {NumberOfTickets}\nCustomer Name: {CustomerName}\nContact Info: {ContactInfo}\n";
        }
    }
}
