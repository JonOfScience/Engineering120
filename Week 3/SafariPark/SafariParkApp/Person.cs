using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SafariParkApp
{
    public class Person
    {
        // private readonly string _hairColour;
        public string FirstName { get; set; }
        public string LastName { get; set; }

        //public int Age { get; set; }

        // The full functionality of the above
        private int _age;
        public int Age
        {
            get { return _age; }
            set { _age = value < 0 ? throw new ArgumentException() : value; }
        }

        public Person(string firstName, string lastName, int age)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
        }

        public Person(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public string FullName => $"{FirstName} {LastName}";
    }
}
