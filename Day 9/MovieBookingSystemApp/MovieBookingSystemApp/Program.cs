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
        private static FeedbackManager _feedbackManager;

        static void Main(string[] args)
        {
            // Initialize movie manager, booking manager, and feedback manager
            _movieManager = new MovieManager();
            _bookingManager = new BookingManager();
            _feedbackManager = new FeedbackManager();

            // Run the main menu
            DisplayMainMenu();
        }

        // Display main menu options
        //static void DisplayMainMenu()
        //{
        //    while (true)
        //    {
        //        Console.Clear(); // Clear the console screen
        //        Console.WriteLine("Welcome to the Movie Booking System!");
        //        Console.WriteLine("1. View Movie Listing");
        //        Console.WriteLine("2. Book Tickets");
        //        Console.WriteLine("3. Cancel Tickets");
        //        Console.WriteLine("4. Add a New Movie");
        //        Console.WriteLine("5. Edit Movie");
        //        Console.WriteLine("6. Delete Movie");
        //        Console.WriteLine("7. Provide Feedback");
        //        Console.WriteLine("8. View All Feedback");
        //        Console.WriteLine("9. Exit");

        //        Console.Write("Enter your choice: ");
        //        string choice = Console.ReadLine();

        //        switch (choice)
        //        {
        //            case "1":
        //                ViewMovieListing();
        //                break;
        //            case "2":
        //                BookTickets();
        //                break;
        //            case "3":
        //                CancelTickets();
        //                break;
        //            case "4":
        //                AddNewMovie();
        //                break;
        //            case "5":
        //                EditMovie();
        //                break;
        //            case "6":
        //                DeleteMovie();
        //                break;
        //            case "7":
        //                ProvideFeedback();
        //                break;
        //            case "8":
        //                ViewAllFeedback();
        //                break;
        //            case "9":
        //                Console.WriteLine("Thank you for using the Movie Booking System. Goodbye!");
        //                Environment.Exit(0);
        //                break;
        //            default:
        //                Console.WriteLine("Invalid choice. Please try again.");
        //                break;
        //        }
        //    }
        //}

        static void DisplayMainMenu()
        {
            while (true)
            {
                Console.Clear(); // Clear the console screen
                Console.WriteLine("Welcome to the Movie Booking System!");
                Console.WriteLine("1. View Movie Listing");
                Console.WriteLine("2. Book Tickets");
                Console.WriteLine("3. Cancel Tickets");
                Console.WriteLine("4. Provide Feedback");
                Console.WriteLine("5. View All Feedback");
                Console.WriteLine("6. Exit");

                Console.Write("Enter your choice: ");
                string choice = Console.ReadLine();

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
                        ProvideFeedback();
                        break;
                    case "5":
                        ViewAllFeedback();
                        break;
                    case "6":
                        Console.WriteLine("Thank you for using the Movie Booking System. Goodbye!");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Please try again.");
                        break;
                }
            }
        }

        // Method to display the list of movies
        static void ViewMovieListing()
        {
            try
            {
                List<Movie> movies = _movieManager.GetAllMovies();
                Console.WriteLine("Movie Listing:");
                foreach (var movie in movies)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(movie);
                    Console.WriteLine("-------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Method to book tickets for a movie
        static void BookTickets()
        {
            try
            {
                Console.WriteLine("Select a movie to book tickets:");
                List<Movie> movies = _movieManager.GetAllMovies();
                Console.WriteLine("-------------------------------");
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {movies[i].Title}");
                }
                Console.WriteLine("-------------------------------");

                Console.Write("Enter the number corresponding to the movie: ");
                int movieIndex;
                if (!int.TryParse(Console.ReadLine(), out movieIndex) || movieIndex < 1 || movieIndex > movies.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }

                Movie selectedMovie = movies[movieIndex - 1];
                Console.WriteLine($"You have selected '{selectedMovie.Title}'.");

                Console.WriteLine("Select a timing for the movie:");
                Console.WriteLine("-------------------------------");
                for (int i = 0; i < selectedMovie.ScreeningTimes.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {selectedMovie.ScreeningTimes[i].ToString("HH:mm")}");
                }
                Console.WriteLine("-------------------------------");

                Console.Write("Enter the number corresponding to the timing: ");
                int timingIndex;
                if (!int.TryParse(Console.ReadLine(), out timingIndex) || timingIndex < 1 || timingIndex > selectedMovie.ScreeningTimes.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                DateTime selectedTiming = selectedMovie.ScreeningTimes[timingIndex - 1];

                Console.Write("Enter your name: ");
                string name = Console.ReadLine();

                Console.Write("Enter your contact information: ");
                string contactInfo = Console.ReadLine();

                Console.Write("Enter the number of tickets: ");
                int numberOfTickets;
                if (!int.TryParse(Console.ReadLine(), out numberOfTickets) || numberOfTickets <= 0)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number of tickets.");
                    return;
                }

                // Calculate payment details
                decimal ticketPrice = selectedMovie.TicketPrice;
                decimal totalCost = CalculateTotalCost(ticketPrice, numberOfTickets);
                decimal discount = CalculateDiscount(totalCost);
                decimal discountedTotalCost = totalCost - discount;

                Booking booking = new Booking(0, selectedMovie.Id, selectedTiming, numberOfTickets, name, contactInfo);

                // Add booking to the booking manager
                _bookingManager.AddBooking(booking);

                Console.WriteLine("-------------------------------");
                // Display booking confirmation
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
            catch (Exception ex)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Method to cancel tickets
        static void CancelTickets()
        {
            try
            {
                Console.WriteLine("Enter the booking ID to cancel:");
                int bookingId;
                if (!int.TryParse(Console.ReadLine(), out bookingId) || bookingId <= 0)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("Invalid input. Please enter a valid booking ID.");
                    Console.WriteLine("-------------------------------");
                    return;
                }

                // Retrieve booking details
                Booking booking = _bookingManager.GetBookingById(bookingId);

                if (booking != null)
                {
                    _bookingManager.RemoveBooking(bookingId);
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Booking with ID {bookingId} has been canceled successfully.");
                    Console.WriteLine("-------------------------------");
                }
                else
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine($"Booking with ID {bookingId} not found. Please enter a valid booking ID.");
                    Console.WriteLine("-------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Method to calculate total cost
        static decimal CalculateTotalCost(decimal ticketPrice, int numberOfTickets)
        {
            return ticketPrice * numberOfTickets;
        }

        // Method to calculate discount
        static decimal CalculateDiscount(decimal totalCost)
        {
            return totalCost * 0.05m; // 5% discount
        }

        // Method to add a new movie
        //static void AddNewMovie()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter details for the new movie:");
        //        Console.Write("Title: ");
        //        string title = Console.ReadLine();

        //        Console.Write("Genre: ");
        //        string genre = Console.ReadLine();

        //        Console.Write("Duration (minutes): ");
        //        int duration;
        //        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid duration in minutes.");
        //            Console.Write("Duration (minutes): ");
        //        }

        //        Console.Write("Ticket Price: ");
        //        decimal ticketPrice;
        //        while (!decimal.TryParse(Console.ReadLine(), out ticketPrice) || ticketPrice <= 0)
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid ticket price.");
        //            Console.Write("Ticket Price: ");
        //        }

        //        Movie newMovie = new Movie(0, title, genre, duration, new List<DateTime>(), ticketPrice);
        //        _movieManager.AddMovie(newMovie);

        //        Console.WriteLine("-------------------------------");
        //        Console.WriteLine("New movie added successfully!");
        //        Console.WriteLine("-------------------------------");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("-------------------------------");
        //        Console.WriteLine($"Error: {ex.Message}");
        //        Console.WriteLine("-------------------------------");
        //    }

        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //}

        //// Method to edit movie details
        //static void EditMovie()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter the ID of the movie to edit:");
        //        int movieId;
        //        if (!int.TryParse(Console.ReadLine(), out movieId) || movieId <= 0)
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid movie ID.");
        //            return;
        //        }

        //        Movie movieToEdit = _movieManager.GetMovieById(movieId);
        //        if (movieToEdit == null)
        //        {
        //            Console.WriteLine("Movie not found. Please enter a valid movie ID.");
        //            return;
        //        }

        //        Console.WriteLine("Enter new details for the movie:");
        //        Console.Write("Title: ");
        //        string title = Console.ReadLine();

        //        Console.Write("Genre: ");
        //        string genre = Console.ReadLine();

        //        Console.Write("Duration (minutes): ");
        //        int duration;
        //        while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid duration in minutes.");
        //            Console.Write("Duration (minutes): ");
        //        }

        //        Console.Write("Ticket Price: ");
        //        decimal ticketPrice;
        //        while (!decimal.TryParse(Console.ReadLine(), out ticketPrice) || ticketPrice <= 0)
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid ticket price.");
        //            Console.Write("Ticket Price: ");
        //        }

        //        movieToEdit.Title = title;
        //        movieToEdit.Genre = genre;
        //        movieToEdit.DurationMinutes = duration;
        //        movieToEdit.TicketPrice = ticketPrice;

        //        _movieManager.UpdateMovie(movieToEdit);

        //        Console.WriteLine("-------------------------------");
        //        Console.WriteLine("Movie details updated successfully!");
        //        Console.WriteLine("-------------------------------");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("-------------------------------");
        //        Console.WriteLine($"Error: {ex.Message}");
        //        Console.WriteLine("-------------------------------");
        //    }

        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //}

        //// Method to delete a movie
        //static void DeleteMovie()
        //{
        //    try
        //    {
        //        Console.WriteLine("Enter the ID of the movie to delete:");
        //        int movieId;
        //        if (!int.TryParse(Console.ReadLine(), out movieId) || movieId <= 0)
        //        {
        //            Console.WriteLine("Invalid input. Please enter a valid movie ID.");
        //            return;
        //        }

        //        Movie movieToDelete = _movieManager.GetMovieById(movieId);
        //        if (movieToDelete == null)
        //        {
        //            Console.WriteLine("Movie not found. Please enter a valid movie ID.");
        //            return;
        //        }

        //        _movieManager.RemoveMovie(movieId);

        //        Console.WriteLine("-------------------------------");
        //        Console.WriteLine("Movie deleted successfully!");
        //        Console.WriteLine("-------------------------------");
        //    }
        //    catch (Exception ex)
        //    {
        //        Console.WriteLine("-------------------------------");
        //        Console.WriteLine($"Error: {ex.Message}");
        //        Console.WriteLine("-------------------------------");
        //    }

        //    Console.WriteLine("Press any key to continue...");
        //    Console.ReadKey();
        //}

        // Method to provide feedback
        static void ProvideFeedback()
        {
            try
            {
                Console.WriteLine("Please provide your feedback:");
                Console.Write("Your Name: ");
                string customerName = Console.ReadLine();

                Console.Write("Contact Information: ");
                string contactInfo = Console.ReadLine();

                // Select a movie for feedback
                Console.WriteLine("Select a movie for feedback:");
                List<Movie> movies = _movieManager.GetAllMovies();
                for (int i = 0; i < movies.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {movies[i].Title}");
                }
                Console.Write("Enter the number corresponding to the movie: ");
                int movieIndex;
                if (!int.TryParse(Console.ReadLine(), out movieIndex) || movieIndex < 1 || movieIndex > movies.Count)
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    return;
                }
                string selectedMovieName = movies[movieIndex - 1].Title;

                Console.WriteLine("Message: ");
                string message = Console.ReadLine();

                Console.Write("Rating (1 to 5 stars): ");
                int rating;
                while (!int.TryParse(Console.ReadLine(), out rating) || rating < 1 || rating > 5)
                {
                    Console.WriteLine("Invalid input. Please enter a rating between 1 and 5.");
                    Console.Write("Rating (1 to 5 stars): ");
                }

                Feedback feedback = new Feedback(customerName, contactInfo, selectedMovieName, message, rating);
                _feedbackManager.AddFeedback(feedback);

                Console.WriteLine("-------------------------------");
                Console.WriteLine("Thank you for your feedback!");
                Console.WriteLine("-------------------------------");
            }
            catch (Exception ex)
            {
                Console.WriteLine("-------------------------------");
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("-------------------------------");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }

        // Method to view all feedback
        static void ViewAllFeedback()
        {
            try
            {
                List<Feedback> feedbacks = _feedbackManager.GetAllFeedback();
                Console.WriteLine("All Feedbacks:");
                foreach (var feedback in feedbacks)
                {
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine(feedback);
                    Console.WriteLine("-------------------------------");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }

            Console.WriteLine("Press any key to continue...");
            Console.ReadKey();
        }
    }
}
