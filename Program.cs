using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        // This is our employee-getting code now
        List<Employee> employees = GetEmployees();

        // Call to PrintEmployees() Util method
        Util.PrintEmployees(employees);

        // Call to MakeCSV() Util method
        Util.MakeCSV(employees);

        // Call to MakeBadges() Util method
        Util.MakeBadges(employees);
    }
    static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        
        // Collect user values until the value is an empty string
        while (true)
        {
            Console.WriteLine("Please enter a name (leave empty to exit): ");
            string firstName = Console.ReadLine() ?? "";

            // Break if the user hits ENTER without typing a name
            if (firstName == "")
            {
                break;
            }

            Console.Write("Enter last name: ");
            string lastName = Console.ReadLine() ?? "";

            Console.Write("Enter ID: ");
            int id = Int32.Parse(Console.ReadLine() ?? "");

            Console.Write("Enter Photo URL: ");
            string photoUrl = Console.ReadLine() ?? "";

            // Create a new Employee instance
            Employee currentEmployee = new Employee(firstName, lastName, id, photoUrl);
            // Add currentEmployee, not a string
            employees.Add(currentEmployee);
        }
        return employees;
    }
  }
}