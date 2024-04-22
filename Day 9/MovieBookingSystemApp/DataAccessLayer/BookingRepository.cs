using System;
using System.Collections.Generic;
using Models;

namespace DataAccessLayer
{
    /// <summary>
    /// Repository class for managing bookings.
    /// </summary>
    public class BookingRepository
    {
        private List<Booking> _bookings;

        /// <summary>
        /// Initializes a new instance of the BookingRepository class.
        /// </summary>
        public BookingRepository()
        {
            _bookings = new List<Booking>();
        }

        /// <summary>
        /// Retrieves all bookings.
        /// </summary>
        /// <returns>A list of all bookings.</returns>
        public List<Booking> GetAllBookings()
        {
            return _bookings;
        }

        /// <summary>
        /// Adds a new booking to the repository.
        /// </summary>
        /// <param name="booking">The booking to add.</param>
        public void AddBooking(Booking booking)
        {
            _bookings.Add(booking);
        }

        /// <summary>
        /// Removes a booking from the repository by its ID.
        /// </summary>
        /// <param name="id">The ID of the booking to remove.</param>
        public void RemoveBooking(int id)
        {
            Booking bookingToRemove = _bookings.Find(b => b.Id == id);
            if (bookingToRemove != null)
            {
                _bookings.Remove(bookingToRemove);
            }
        }

        /// <summary>
        /// Retrieves a booking by its ID.
        /// </summary>
        /// <param name="id">The ID of the booking to retrieve.</param>
        /// <returns>The booking with the specified ID.</returns>
        public Booking GetBookingById(int id)
        {
            return _bookings.Find(b => b.Id == id);
        }
    }
}
