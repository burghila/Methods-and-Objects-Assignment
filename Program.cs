using System;

// Define the Person class with properties for the first and last name.
class Person
{
    // Property for first name
    public string FirstName { get; set; }
    // Property for last name
    public string LastName { get; set; }

    // Method to display the full name of the person
    public void SayName()
    {
        Console.WriteLine("Name: " + FirstName + " " + LastName);
    }
}

// Define the Employee class that inherits from Person and includes an ID property
class Employee : Person
{
    // Property for employee ID
    public int Id { get; set; }
}

// Main program class
class Program
{
    static void Main()
    {
        // Create a new Employee object
        Employee employee = new Employee
        {
            FirstName = "Sample", // Set first name
            LastName = "Student", // Set last name
            Id = 1 // Set employee ID
        };

        // Call SayName method from the Person class on the Employee object
        employee.SayName();

        // Keep the console window open until a key is pressed
        Console.ReadKey();
    }
}
