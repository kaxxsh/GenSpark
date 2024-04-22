using System;

namespace Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public DateTime ScreeningTime { get; set; }
        public int NumberOfTickets { get; set; }
        public string CustomerName { get; set; }
        public string ContactInfo { get; set; }

        public Booking(int id, int movieId, DateTime screeningTime, int numberOfTickets, string customerName, string contactInfo)
        {
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
            return $"Booking ID: {Id}\nMovie ID: {MovieId}\nScreening Time: {ScreeningTime}\nNumber of Tickets: {NumberOfTickets}\nCustomer Name: {CustomerName}\nContact Info: {ContactInfo}\n";
        }
    }
}
