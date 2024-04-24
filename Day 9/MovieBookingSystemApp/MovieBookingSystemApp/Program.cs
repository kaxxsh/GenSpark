using System;
using System.Collections.Generic;
using BusinessLogicLayer; // Importing business logic layer
using Models; // Importing models

namespace MovieBookingSystemApp
{
    internal class Program
    {
        private static MovieManager _movieManager; // Movie manager instance
        private static BookingManager _bookingManager; // Booking manager instance

        static void Main(string[] args)
        {
            InitializeManagers(); // Initialize managers
            DisplayMainMenu(); // Display main menu
        }

        // Initialize movie and booking managers
        static void InitializeManagers()
        {
            _movieManager = new MovieManager(); // Initialize movie manager
            _bookingManager = new BookingManager(); // Initialize booking manager
        }

        // Display main menu options and handle user input
        static void DisplayMainMenu()
        {
            while (true)
            {
                Console.Clear(); // Clear console
                PrintMainMenu(); // Print main menu options
                string choice = GetUserChoice(); // Get user choice

                // Handle user choice
                switch (choice)
                {
                    case "1":
                        ViewMovieListing(); // View movie listing
                        break;
                    case "2":
                        BookTickets(); // Book tickets
                        break;
                    case "3":
                        CancelTickets(); // Cancel tickets
                        break;
                    case "4":
                        ExitApplication(); // Exit application
                        break;
                    default:
                        DisplayInvalidChoiceMessage(); // Display invalid choice message
                        break;
                }
            }
        }

        // Print main menu options
        static void PrintMainMenu()
        {
            Console.WriteLine("Welcome to the Movie Booking System!");
            Console.WriteLine("1. View Movie Listing");
            Console.WriteLine("2. Book Tickets");
            Console.WriteLine("3. Cancel Tickets");
            Console.WriteLine("4. Exit");
            Console.Write("Enter your choice: ");
        }

        // Get user choice from console input
        static string GetUserChoice()
        {
            return Console.ReadLine();
        }

        // View movie listing
        static void ViewMovieListing()
        {
            try
            {
                List<Movie> movies = _movieManager.GetAllMovies(); // Get all movies
                DisplayMovieListing(movies); // Display movie listing
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message); // Display error message if an exception occurs
            }
            Console.ReadKey(); // Wait for user input
        }

        // Display movie listing
        static void DisplayMovieListing(List<Movie> movies)
        {
            Console.WriteLine("Movie Listing:");
            foreach (var movie in movies)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine(movie); // Display movie details
                Console.WriteLine("-------------------------------");
            }
        }

        // Book tickets
        static void BookTickets()
        {
            try
            {
                // Get user input for booking details
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

                // Create booking
                Booking booking = CreateBooking(selectedMovie, selectedTiming, numberOfTickets, name, contactInfo);

                // Display booking confirmation
                DisplayBookingConfirmation(booking, selectedMovie, selectedTiming, numberOfTickets, name, contactInfo, ticketPrice, discountedTotalCost);
            }
            catch (Exception ex)
            {
                DisplayErrorMessage(ex.Message); // Display error message if an exception occurs
            }
            Console.ReadKey(); // Wait for user input
        }

        // Get user input for movie selection
        static int GetMovieSelection()
        {
            List<Movie> movies = _movieManager.GetAllMovies(); // Get all movies
            PrintMovieSelectionOptions(movies); // Print movie selection options
            return GetUserInputAsInt(1, movies.Count); // Get user input as integer
        }

        // Print movie selection options
        static void PrintMovieSelectionOptions(List<Movie> movies)
        {
            Console.WriteLine("Select a movie to book tickets:");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < movies.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {movies[i].Title}"); // Display movie titles
            }
            Console.WriteLine("-------------------------------");
        }

        // Get selected movie based on user input
        static Movie GetSelectedMovie(int movieIndex)
        {
            List<Movie> movies = _movieManager.GetAllMovies(); // Get all movies
            return movies[movieIndex - 1]; // Return selected movie
        }

        // Get selected timing for the movie
        static DateTime GetSelectedTiming(Movie selectedMovie)
        {
            Console.WriteLine("Select a timing for the movie:");
            Console.WriteLine("-------------------------------");
            for (int i = 0; i < selectedMovie.ScreeningTimes.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {selectedMovie.ScreeningTimes[i].ToString("HH:mm")}"); // Display screening times
            }
            Console.WriteLine("-------------------------------");

            int timingIndex = GetUserInputAsInt(1, selectedMovie.ScreeningTimes.Count); // Get user input for timing selection
            return selectedMovie.ScreeningTimes[timingIndex - 1]; // Return selected timing
        }

        // Get customer name from user input
        static string GetCustomerName()
        {
            Console.Write("Enter your name: ");
            return Console.ReadLine();
        }

        // Get customer contact information from user input
        static string GetCustomerContactInfo()
        {
            Console.Write("Enter your contact information: ");
            return Console.ReadLine();
        }

        // Get number of tickets from user input
        static int GetNumberOfTickets()
        {
            Console.Write("Enter the number of tickets: ");
            return GetUserInputAsInt(1, int.MaxValue); // Get user input as integer
        }

        // Get user input as integer within specified range
        static int GetUserInputAsInt(int minValue, int maxValue)
        {
            int userInput;
            while (!int.TryParse(Console.ReadLine(), out userInput) || userInput < minValue || userInput > maxValue)
            {
                Console.WriteLine($"Invalid input. Please enter a number between {minValue} and {maxValue}.");
            }
            return userInput;
        }

        // Calculate total cost of tickets
        static decimal CalculateTotalCost(decimal ticketPrice, int numberOfTickets)
        {
            return ticketPrice * numberOfTickets;
        }

        // Calculate discount on total cost
        static decimal CalculateDiscount(decimal totalCost)
        {
            return totalCost * 0.05m; // 5% discount
        }

        // Calculate discounted total cost
        static decimal CalculateDiscountedTotalCost(decimal totalCost, decimal discount)
        {
            return totalCost - discount;
        }

        // Create booking
        static Booking CreateBooking(Movie selectedMovie, DateTime selectedTiming, int numberOfTickets, string name, string contactInfo)
        {
            int id = GenerateBookingId(); // Generate a unique booking ID
            return new Booking(id, selectedMovie.Id, selectedTiming, numberOfTickets, name, contactInfo); // Return new booking instance
        }

        // Generate a unique booking ID
        static int GenerateBookingId()
        {
            // You can implement your logic for generating a unique ID here
            // For simplicity, you can use a counter or any other method that ensures uniqueness
            // In a real-world scenario, you might use a database-generated ID or another mechanism
            // For this example, let's increment a static variable
            return ++lastBookingId;
        }

        static int lastBookingId = 0;

        // Display booking confirmation
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

        // Cancel tickets
        static void CancelTickets()
        {
            try
            {
                Console.Write("Enter the booking ID to cancel: ");
                int bookingId;
                if (!int.TryParse(Console.ReadLine(), out bookingId) || bookingId <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid booking ID.");
                    return;
                }
                // Call the BookingManager to remove the booking
                _bookingManager.RemoveBooking(bookingId);
                Console.WriteLine($"Booking with ID {bookingId} has been canceled successfully.");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Exit the application
        static void ExitApplication()
        {
            Console.WriteLine("Thank you for using the Movie Booking System. Goodbye!");
            Environment.Exit(0); // Exit application
        }

        // Display invalid choice message
        static void DisplayInvalidChoiceMessage()
        {
            Console.WriteLine("Invalid choice. Please try again.");
        }

        // Display error message
        static void DisplayErrorMessage(string errorMessage)
        {
            Console.WriteLine($"Error: {errorMessage}");
        }
    }
}
