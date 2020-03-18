using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp3
{
    public class Person
    {
        public string FirstName { get; set; }
        public string? MiddleName { get; set; }
        public string LastName { get; set; }

        public Person(string name, string lastname)
        {
            this.FirstName = name;
            this.LastName = lastname;
        }

        public Person(string name, string middleName, string lastName)
        {
            this.FirstName = name;
            this.MiddleName = middleName;
            this.LastName = lastName;
        }
    }
}
