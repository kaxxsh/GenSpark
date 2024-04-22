using System;
using System.Collections.Generic;
using DataAccessLayer;
using Models;

namespace BusinessLogicLayer
{
    /// <summary>
    /// Manages booking-related operations by interacting with the BookingRepository.
    /// </summary>
    public class BookingManager
    {
        private BookingRepository _bookingRepository;

        /// <summary>
        /// Initializes a new instance of the BookingManager class.
        /// </summary>
        public BookingManager()
        {
            _bookingRepository = new BookingRepository();
        }

        /// <summary>
        /// Retrieves all bookings.
        /// </summary>
        /// <returns>A list of all bookings.</returns>
        public List<Booking> GetAllBookings()
        {
            return _bookingRepository.GetAllBookings();
        }

        /// <summary>
        /// Adds a new booking.
        /// </summary>
        /// <param name="booking">The booking to add.</param>
        public void AddBooking(Booking booking)
        {
            _bookingRepository.AddBooking(booking);
        }

        /// <summary>
        /// Removes a booking by its ID.
        /// </summary>
        /// <param name="id">The ID of the booking to remove.</param>
        public void RemoveBooking(int id)
        {
            _bookingRepository.RemoveBooking(id);
        }

        /// <summary>
        /// Retrieves a booking by its ID.
        /// </summary>
        /// <param name="id">The ID of the booking to retrieve.</param>
        /// <returns>The booking with the specified ID, or null if not found.</returns>
        public Booking GetBookingById(int id)
        {
            return _bookingRepository.GetBookingById(id);
        }
    }
}
