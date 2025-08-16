using System;

namespace ExampleApp
{
    // Define the Person class
    class Person
    {
        // Auto-implemented properties
        public string FullName { get; set; }
        //  Changed
        public int Age { get; set; }

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
            //Changed
            Console.WriteLine($"Age: {Age}");
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
