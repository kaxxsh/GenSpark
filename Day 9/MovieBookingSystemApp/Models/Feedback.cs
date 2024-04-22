using System;

namespace Models
{
    public class Feedback
    {
        public string CustomerName { get; set; }
        public string ContactInfo { get; set; }
        public string MovieName { get; set; } // New property for the movie name
        public string Message { get; set; }
        public int Rating { get; set; } // Rating out of 5 stars

        // Constructor with parameters including the movie name
        public Feedback(string customerName, string contactInfo, string movieName, string message, int rating)
        {
            CustomerName = customerName;
            ContactInfo = contactInfo;
            MovieName = movieName;
            Message = message;
            Rating = rating;
        }

        // Override ToString method to provide a string representation of the feedback
        public override string ToString()
        {
            return $"Customer Name: {CustomerName}\nContact Info: {ContactInfo}\nMovie Name: {MovieName}\nMessage: {Message}\nRating: {Rating} stars";
        }
    }
}
