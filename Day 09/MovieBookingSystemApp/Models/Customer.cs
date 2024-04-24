using System;

namespace Models
{
    public class Customer
    {
        // Properties
        public int Id { get; set; } // Unique identifier of the customer
        public string Name { get; set; } // Name of the customer
        public string ContactInfo { get; set; } // Contact information of the customer

        // Constructor
        public Customer(int id, string name, string contactInfo)
        {
            // Initialize properties with provided values
            Id = id;
            Name = name;
            ContactInfo = contactInfo;
        }

        // Override ToString method to provide a string representation of the object
        public override string ToString()
        {
            // Format customer details including ID, name, and contact information
            return $"Customer ID: {Id}\nName: {Name}\nContact Info: {ContactInfo}\n";
        }
    }
}
