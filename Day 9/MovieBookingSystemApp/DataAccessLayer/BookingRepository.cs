using System;
using System.Collections.Generic;
using Models;

namespace DataAccessLayer
{
    public class BookingRepository
    {
        private List<Booking> _bookings; // List to store bookings

        // Constructor
        public BookingRepository()
        {
            // Initialize the list of bookings
            _bookings = new List<Booking>();
        }

        // Method to get all bookings
        public List<Booking> GetAllBookings()
        {
            return _bookings;
        }

        // Method to add a new booking
        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        // Method to remove a booking by its ID
        public void RemoveBooking(int id)
        {
            // Find the booking to remove by its ID
            Booking bookingToRemove = _bookings.Find(b => b.Id == id);
            // If the booking exists, remove it from the list
            if (bookingToRemove != null)
            {
                _bookings.Remove(bookingToRemove);
            }
        }

        // Method to get a booking by its ID
        public Booking GetBookingById(int id)
        {
            // Find and return the booking with the specified ID
            return _bookings.Find(b => b.Id == id);
        }
    }
}
