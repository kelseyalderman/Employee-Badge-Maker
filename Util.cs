// File contains all output-related logic
using System;
using System.IO;
using System.Collections.Generic;

namespace CatWorx.BadgeMaker
{
    class Util
    {
        // Method with list parameeter
        public static void PrintEmployees(List<Employee> employees)
        {
            for (int i = 0; i < employees.Count; i++)
            {
                string template = "{0,-10}\t{1,-20}\t{2}";
                Console.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
            }
        }
        public static void MakeCSV(List<Employee> employees)
        {
            // Check to seee if folder exists
            if (!Directory.Exists("data"))
            {
                // If not, create it
                Directory.CreateDirectory("data");
            }

            // Create the CSV
            using (StreamWriter file = new StreamWriter("data/employees.csv"))
            {
                // Any code that needs the StreamWriter goes here

                // Provide colomn headers 
                file.WriteLine("ID,Name,PhotoURL");

                // Loop over employees
                for (int i = 0; i < employees.Count; i++)
                {
                    string template = "{0,-10}\t{1,-20}\t{2}";
                    file.WriteLine(String.Format(template, employees[i].GetId(), employees[i].GetFullName(), employees[i].GetPhotoUrl()));
                }
            }
        }
    }
}