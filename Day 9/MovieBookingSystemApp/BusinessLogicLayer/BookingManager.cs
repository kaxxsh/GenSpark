using System;
using System.Collections.Generic;
using DataAccessLayer;
using Models;

namespace BusinessLogicLayer
{
    public class BookingManager
    {
        private BookingRepository _bookingRepository;

        public BookingManager()
        {
            _bookingRepository = new BookingRepository();
        }

        // Method to get all bookings
        public List<Booking> GetAllBookings()
        {
            return _bookingRepository.GetAllBookings();
        }

        // Method to add a new booking
        public void AddBooking(Booking booking)
        {
            _bookingRepository.AddBooking(booking);
        }

        // Method to remove a booking by its ID
        public void RemoveBooking(int id)
        {
            _bookingRepository.RemoveBooking(id);
        }

        // Method to get a booking by its ID
        public Booking GetBookingById(int id)
        {
            return _bookingRepository.GetBookingById(id);
        }
    }
}
