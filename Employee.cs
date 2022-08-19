using System;

namespace CatWorx.BadgeMaker
{
    class Employee
    {
        public string FirstName;
        public string LastName;
        public int Id;
        public string PhotoUrl;

        // Constructor that accepts a first name and sets the FirstName property
        public Employee(string firstName, string lastName) {
            FirstName = firstName;
            LastName = lastName;
        }

        public string GetFullName() {
            return FirstName + " " + LastName;
        }
    }
}