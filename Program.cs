using System;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
  class Program
  {
    static void Main(string[] args)
    {
        // This is our employee-getting code now
        List<string> employees = GetEmployees();

        // This is our employee-printing code now
        PrintEmployees(employees);
    }
    static List<string> GetEmployees()
    {
        List<string> employees = new List<string>();
        
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
            employees.Add(input);
        }
        return employees;
    }
    static void PrintEmployees(List<string> employees)
    {
        for (int i = 0; i < employees.Count; i++)
        {
            Console.WriteLine(employees[i]);
        }
    }
  }
}