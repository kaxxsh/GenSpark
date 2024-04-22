using System;

namespace Models
{
    /// <summary>
    /// Represents a customer who can book tickets for movies.
    /// </summary>
    public class Customer
    {
        // Properties
        public int Id { get; set; }             // Unique identifier for the customer
        public string Name { get; set; }        // Name of the customer
        public string ContactInfo { get; set; } // Contact information of the customer

        /// <summary>
        /// Initializes a new instance of the Customer class with the specified parameters.
        /// </summary>
        /// <param name="id">The unique identifier for the customer.</param>
        /// <param name="name">The name of the customer.</param>
        /// <param name="contactInfo">The contact information of the customer.</param>
        public Customer(int id, string name, string contactInfo)
        {
            Id = id;
            Name = name;
            ContactInfo = contactInfo;
        }

        /// <summary>
        /// Overrides the ToString method to provide a string representation of the customer object.
        /// </summary>
        /// <returns>A string representing the customer details.</returns>
        public override string ToString()
        {
            return $"Customer ID: {Id}\nName: {Name}\nContact Info: {ContactInfo}\n";
        }
    }
}
