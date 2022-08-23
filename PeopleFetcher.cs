using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace CatWorx.BadgeMaker
{
    class PeopleFetcher
    {
        public static List<Employee> GetEmployees()
        {
            List<Employee> employees = new List<Employee>();
            
            // Collect user values until the value is an empty string
            
            while (true)
            {
                Console.WriteLine("Please enter first name (leave empty to exit): ");
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
        async public static Task<List<Employee>> GetFromApi()
        {
            List<Employee> employees = new List<Employee>();
            
            using (HttpClient client = new HttpClient())
            {
                string response = await client.GetStringAsync("https://randomuser.me/api/?results=10&nat=us&inc=name,id,picture");
                JObject json = JObject.Parse(response);

                foreach (JToken item in json.SelectToken("results")!)
                {
                    // Parse JSON data
                    Employee emp = new Employee
                    (
                        item.SelectToken("name.first")!.ToString(),
                        item.SelectToken("name.last")!.ToString(),
                        Int32.Parse(item.SelectToken("id.value")!.ToString().Replace("-", "")),
                        item.SelectToken("picture.large")!.ToString()
                    );
                    employees.Add(emp);
                }
            }
            return employees;
        }
    }
}