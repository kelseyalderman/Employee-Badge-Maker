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

        // This is our employee-printing code now
        PrintEmployees(employees);
    }
    static List<Employee> GetEmployees()
    {
        List<Employee> employees = new List<Employee>();
        
        // Collect user values until the value is an empty string
        while (true)
        {
            Console.WriteLine("Please enter a name (leave empty to exit): ");
            string input = Console.ReadLine() ?? "";

            // Break if the user hits ENTER without typing a name
            if (input == "")
            {
                break;
            }
            // Create a new Employee instance
            Employee currentEmployee = new Employee(input, "Smith");
            // Add currentEmployee, not a string
            employees.Add(currentEmployee);
        }
        return employees;
    }
    static void PrintEmployees(List<Employee> employees)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine(employees[i].GetFullName());
        }
    }
  }
}