using System;
using System.Collections.Generic;
using BusinessLogicLayer;
using Models;

namespace MovieBookingSystemApp
{
    internal class Program
    {
        private static MovieManager _movieManager;
        private static BookingManager _bookingManager;

        static void Main(string[] args)
        {
            InitializeManagers();
            DisplayMainMenu();
        }

        static void InitializeManagers()
        {
            _movieManager = new MovieManager();
            _bookingManager = new BookingManager();
        }

        static void DisplayMainMenu()
        {
            while (true)
            {
                Console.Clear();
                PrintMainMenu();
                string choice = GetUserChoice();

                switch (choice)
                {
                    case "1":
                        ViewMovieListing();
                        break;
                    case "2":
                        BookTickets();
                        break;
                    case "3":
                        CancelTickets();
                        break;
                    case "4":
                        ExitApplication();
                        break;
                    default:
                        DisplayInvalidChoiceMessage();
                        break;
                }
            }
        }

        static void PrintMainMenu()
        {
            Console.WriteLine("Welcome to the Movie Booking System!");
            Console.WriteLine("1. View Movie Listing");
            Console.WriteLine("2. Book Tickets");
            Console.WriteLine("3. Cancel Tickets");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }

        static string GetUserChoice()
        {
            return Console.ReadLine();
        }

        static void ViewMovieListing()
        {
            try
            {
                List<Movie> movies = _movieManager.GetAllMovies();
                DisplayMovieListing(movies);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
            Console.ReadKey();
        }

        static void DisplayMovieListing(List<Movie> movies)
        {
            Console.WriteLine("Movie Listing:");
            foreach (var movie in movies)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(movie);
                Console.WriteLine("-------------------------------");
            }
        }

        static void BookTickets()
        {
            try
            {
                int movieIndex = GetMovieSelection();
                Movie selectedMovie = GetSelectedMovie(movieIndex);
                DateTime selectedTiming = GetSelectedTiming(selectedMovie);
                string name = GetCustomerName();
                string contactInfo = GetCustomerContactInfo();
                int numberOfTickets = GetNumberOfTickets();
                decimal ticketPrice = selectedMovie.TicketPrice;
                decimal totalCost = CalculateTotalCost(ticketPrice, numberOfTickets);
                decimal discount = CalculateDiscount(totalCost);
                decimal discountedTotalCost = CalculateDiscountedTotalCost(totalCost, discount);

                Booking booking = CreateBooking(selectedMovie, selectedTiming, numberOfTickets, name, contactInfo);

                DisplayBookingConfirmation(booking, selectedMovie, selectedTiming, numberOfTickets, name, contactInfo, ticketPrice, discountedTotalCost);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
            Console.ReadKey();
        }

        static int GetMovieSelection()
        {
            List<Movie> movies = _movieManager.GetAllMovies();
            PrintMovieSelectionOptions(movies);
            return GetUserInputAsInt(1, movies.Count);
        }

        static void PrintMovieSelectionOptions(List<Movie> movies)
        {
            Console.WriteLine("Select a movie to book tickets:");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Title}");
            }
            Console.WriteLine("-------------------------------");
        }

        static Movie GetSelectedMovie(int movieIndex)
        {
            List<Movie> movies = _movieManager.GetAllMovies();
            return movies[movieIndex - 1];
        }

        static DateTime GetSelectedTiming(Movie selectedMovie)
        {
            Console.WriteLine("Select a timing for the movie:");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < selectedMovie.ScreeningTimes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {selectedMovie.ScreeningTimes[i].ToString("HH:mm")}");
            }
            Console.WriteLine("-------------------------------");

            int timingIndex = GetUserInputAsInt(1, selectedMovie.ScreeningTimes.Count);
            return selectedMovie.ScreeningTimes[timingIndex - 1];
        }

        static string GetCustomerName()
        {
            Console.Write("Enter your name: ");
            return Console.ReadLine();
        }

        static string GetCustomerContactInfo()
        {
            Console.Write("Enter your contact information: ");
            return Console.ReadLine();
        }

        static int GetNumberOfTickets()
        {
            Console.Write("Enter the number of tickets: ");
            return GetUserInputAsInt(1, int.MaxValue);
        }

        static int GetUserInputAsInt(int minValue, int maxValue)
        {
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < minValue || userInput > maxValue)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {minValue} and {maxValue}.");
            }
            return userInput;
        }

        static decimal CalculateTotalCost(decimal ticketPrice, int numberOfTickets)
        {
            return ticketPrice * numberOfTickets;
        }

        static decimal CalculateDiscount(decimal totalCost)
        {
            return totalCost * 0.05m; // 5% discount
        }

        static decimal CalculateDiscountedTotalCost(decimal totalCost, decimal discount)
        {
            return totalCost - discount;
        }

        static Booking CreateBooking(Movie selectedMovie, DateTime selectedTiming, int numberOfTickets, string name, string contactInfo)
        {
            return new Booking(0, selectedMovie.Id, selectedTiming, numberOfTickets, name, contactInfo);
        }

        static void DisplayBookingConfirmation(Booking booking, Movie selectedMovie, DateTime selectedTiming, int numberOfTickets, string name, string contactInfo, decimal ticketPrice, decimal discountedTotalCost)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\nBooking Confirmation:");
            Console.WriteLine($"Booking ID: {booking.Id}");
            Console.WriteLine($"Movie Title: {selectedMovie.Title}");
            Console.WriteLine($"Screening Time: {selectedTiming}");
            Console.WriteLine($"Number of Tickets: {numberOfTickets}");
            Console.WriteLine($"Customer Name: {name}");
            Console.WriteLine($"Contact Info: {contactInfo}");
            Console.WriteLine($"Ticket Price: Rs {ticketPrice}");
            Console.WriteLine($"Total Cost: Rs {discountedTotalCost} (5% discount applied)");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\nThank you for booking with us!");
            Console.WriteLine("Enjoy the movie!\n");
            Console.WriteLine("-------------------------------");
        }

        static void CancelTickets()
        {
            try
            {
                int bookingId = GetBookingIdToCancel();
                Booking booking = _bookingManager.GetBookingById(bookingId);
                if (booking != null)
                {
                    _bookingManager.RemoveBooking(bookingId);
                    DisplayCancellationSuccessMessage(bookingId);
                }
                else
                {
                    DisplayBookingNotFoundMessage(bookingId);
                }
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message);
            }
            Console.ReadKey();
        }

        static int GetBookingIdToCancel()
        {
            Console.WriteLine("Enter the booking ID to cancel:");
            return GetUserInputAsInt(1, int.MaxValue);
        }

        static void DisplayCancellationSuccessMessage(int bookingId)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Booking with ID {bookingId} has been canceled successfully.");
            Console.WriteLine("-------------------------------");
        }

        static void DisplayBookingNotFoundMessage(int bookingId)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine($"Booking with ID {bookingId} not found. Please enter a valid booking ID.");
            Console.WriteLine("-------------------------------");
        }

        static void ExitApplication()
        {
            Console.WriteLine("Thank you for using the Movie Booking System. Goodbye!");
            Environment.Exit(0);
        }

        static void DisplayInvalidChoiceMessage()
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

        static void DisplayErrorMessage(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }
    }
}
