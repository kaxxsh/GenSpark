using System;

namespace Models
{
    /// <summary>
    /// Represents feedback provided by a customer for a movie.
    /// </summary>
    public class Feedback
    {
        // Properties
        public string CustomerName { get; set; } // Name of the customer providing feedback
        public string ContactInfo { get; set; }  // Contact information of the customer
        public string MovieName { get; set; }    // Name of the movie for which feedback is provided
        public string Message { get; set; }      // Feedback message
        public int Rating { get; set; }          // Rating out of 5 stars

        // Constructor
        /// <summary>
        /// Initializes a new instance of the Feedback class with the specified parameters.
        /// </summary>
        /// <param name="customerName">The name of the customer providing feedback.</param>
        /// <param name="contactInfo">The contact information of the customer.</param>
        /// <param name="movieName">The name of the movie for which feedback is provided.</param>
        /// <param name="message">The feedback message.</param>
        /// <param name="rating">The rating provided by the customer (out of 5 stars).</param>
        public Feedback(string customerName, string contactInfo, string movieName, string message, int rating)
        {
            CustomerName = customerName;
            ContactInfo = contactInfo;
            MovieName = movieName;
            Message = message;
            Rating = rating;
        }

        // Method to override the ToString method to provide a string representation of the feedback
        /// <summary>
        /// Overrides the ToString method to provide a string representation of the feedback.
        /// </summary>
        /// <returns>A string representing the feedback details.</returns>
        public override string ToString()
        {
            return $"Customer Name: {CustomerName}\nContact Info: {ContactInfo}\nMovie Name: {MovieName}\nMessage: {Message}\nRating: {Rating} stars";
        }
    }
}
