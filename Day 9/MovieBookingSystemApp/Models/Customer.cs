using System;

namespace Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }

        public Customer(int id, string name, string contactInfo)
        {
            Id = id;
            Name = name;
            ContactInfo = contactInfo;
        }

        // Override ToString method to provide a string representation of the object
        public override string ToString()
        {
            return $"Customer ID: {Id}\nName: {Name}\nContact Info: {ContactInfo}\n";
        }
    }
}
