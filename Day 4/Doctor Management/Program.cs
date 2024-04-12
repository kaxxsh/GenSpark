using Doctor_Management.Models;
using System;

namespace HospitalManagement
{
    internal class Program
    {
        /// <summary>
        /// Generates a new doctor by obtaining inputs from the user
        /// </summary>
        /// <returns>A Doctor object</returns>
        static Doctor CreateNewDoctor()
        {
            Console.WriteLine("Enter the details of the new doctor:");
            Console.WriteLine("ID:");
            int id;
            while (!int.TryParse(Console.ReadLine(), out id))
            {
                Console.WriteLine("Invalid input. Please enter a valid ID:");
            }

            Console.WriteLine("Name:");
            string? name = Console.ReadLine();

            Console.WriteLine("Age:");
            int age;
            while (!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Invalid input. Please enter a valid age:");
            }

            Console.WriteLine("Experience:");
            int experience;
            while (!int.TryParse(Console.ReadLine(), out experience))
            {
                Console.WriteLine("Invalid input. Please enter a valid experience:");
            }

            Console.WriteLine("Degree:");
            string? degree = Console.ReadLine();

            Console.WriteLine("Specialty:");
            string? specialty = Console.ReadLine();

            Doctor newDoctor = new Doctor(id, name!, age, experience, degree!, specialty!);
            return newDoctor;
        }

        /// <summary>
        /// Displays the details of all doctors
        /// </summary>
        /// <param name="doctors">Array of Doctor objects</param>
        private static void PrintDoctorDetails(ref Doctor[] doctors)
        {
            Console.WriteLine("All Doctors: ");
            foreach (var doctor in doctors)
            {
                doctor.PrintDoctorDetails();
            }
        }

        /// <summary>
        /// Searches for doctors based on specialization
        /// </summary>
        /// <param name="doctors">Array of Doctor objects</param>
        private static void SearchBySpecialty(ref Doctor[] doctors)
        {
            Console.WriteLine("Enter a specialization to search for doctors:");
            string? searchSpecialty = Console.ReadLine();

            Console.WriteLine($"Doctors with specialization {searchSpecialty}:");
            foreach (var doctor in doctors)
            {
                if (doctor.Specialization.Equals(searchSpecialty, StringComparison.OrdinalIgnoreCase))
                {
                    doctor.PrintDoctorDetails();
                }
            }
        }

        /// <summary>
        /// Incorporates a new doctor into the system
        /// </summary>
        /// <param name="doctors">Array of Doctor objects</param>
        private static void AddNewDoctor(ref Doctor[] doctors)
        {
            Doctor newDoctor = CreateNewDoctor();
            Array.Resize(ref doctors, doctors.Length + 1);
            doctors[doctors.Length - 1] = newDoctor;

            Console.WriteLine("New doctor added successfully!");
        }

        static void Main(string[] args)
        {
            const int InitialDoctorCount = 4;
            Doctor[] doctors = new Doctor[InitialDoctorCount];
            doctors[0] = new Doctor(1, "Dr. Mukesh", 60, 45, "MD", "Cardiology");
            doctors[1] = new Doctor(2, "Dr. Suresh", 34, 56, "PhD", "Cardiology");
            doctors[2] = new Doctor(3, "Dr. Rajesh", 45, 24, "MBBS", "Pediatrics");
            doctors[3] = new Doctor(4, "Dr. Ramesh", 25, 65, "MD", "Pediatrics");

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("Menu:");
                Console.WriteLine("1. View all doctors");
                Console.WriteLine("2. Search doctors by specialization");
                Console.WriteLine("3. Add new doctor");
                Console.WriteLine("4. Exit");

                Console.WriteLine("Enter your selection:");
                int? choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        PrintDoctorDetails(ref doctors);
                        break;
                    case 2:
                        SearchBySpecialty(ref doctors);
                        break;
                    case 3:
                        AddNewDoctor(ref doctors);
                        break;
                    case 4:
                        exit = true;
                        break;
                    default:
                        break;
                }
                Console.WriteLine();
            }
        }
    }
}
