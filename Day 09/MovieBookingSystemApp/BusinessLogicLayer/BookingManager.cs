using System;
using System.Collections.Generic;
using DataAccessLayer;
using Models;

namespace BusinessLogicLayer
{
    public class BookingManager
    {
        private BookingRepository _bookingRepository; // Instance of BookingRepository to interact with booking data

        // Constructor
        public BookingManager()
        {
            // Initialize BookingRepository instance
            _bookingRepository = new BookingRepository();
        }

        // Method to get all bookings
        public List<Booking> GetAllBookings()
        {
            // Delegate call to BookingRepository to retrieve all bookings
            return _bookingRepository.GetAllBookings();
        }

        // Method to add a new booking
        public void AddBooking(Booking booking)
        {
            // Delegate call to BookingRepository to add a new booking
            _bookingRepository.AddBooking(booking);
        }

        // Method to remove a booking by its ID
        public void RemoveBooking(int id)
        {
            // Delegate call to BookingRepository to remove a booking by ID
            _bookingRepository.RemoveBooking(id);
        }

        // Method to get a booking by its ID
        public Booking GetBookingById(int id)
        {
            // Delegate call to BookingRepository to retrieve a booking by ID
            return _bookingRepository.GetBookingById(id);
        }
    }
}
