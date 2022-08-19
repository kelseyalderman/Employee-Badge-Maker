namespace CatWorx.BadgeMaker
{
    class Employee
    {
        private string FirstName;
        private string LastName;
        private int Id;
        private string PhotoUrl;

        // Constructor method that accepts a first name and sets the FirstName property
        public Employee(string firstName, string lastName, int id, string photoUrl) {
            FirstName = firstName;
            LastName = lastName;
            Id = id;
            PhotoUrl = photoUrl;
        }

        // Methods to return properties
        public string GetFullName() {
            return FirstName + " " + LastName;
        }
        public int GetId() {
            return Id;
        }
        public string GetPhotoUrl() {
            return PhotoUrl;
        }
        public string GetCompanyName() {
            return "Cat Worx";
        }
    }
}