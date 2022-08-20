using System;
using System.Collections.Generic;
using System.Threading.Tasks;


namespace CatWorx.BadgeMaker
{
  class Program
  {
    async static Task Main(string[] args)
    {
        List<Employee> employees;
        Console.WriteLine("Would you like to fetch employee data from the API? Type YES or NO. ");
        string response = Console.ReadLine() ?? "";

        if (response == "YES" || response == "yes" || response == "Yes" || response == "Y" || response == "y")
        {
            employees = await PeopleFetcher.GetFromApi();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
        }

        if (response == "NO" || response == "no" || response == "No" || response == "N" || response == "n")
        {
            employees = PeopleFetcher.GetEmployees();
            Util.PrintEmployees(employees);
            Util.MakeCSV(employees);
            await Util.MakeBadges(employees);
        }
    }
  }
}