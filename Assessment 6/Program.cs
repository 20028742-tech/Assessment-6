using System;

namespace ExampleApp
{
    // Define the Person class
    class Person
    {
        // Auto-implemented properties
        public string FullName { get; set; }
        public int Years { get; set; }

        // Constructor with parameters
        public Person(string fullName, int years)
        {
            FullName = fullName;
            Years = years;
        }

        // Method to display details
        public void ShowInfo()
        {
            Console.WriteLine($"Full Name: {FullName}");
            Console.WriteLine($"Age: {Years}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create an instance of Person
            Person personOne = new Person("Alex Johnson", 20);

            // Call method to display person details
            personOne.ShowInfo();
        }
    }
}
