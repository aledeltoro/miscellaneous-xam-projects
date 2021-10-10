using System;
using System.Collections.Generic;
using System.Text;

namespace AndroidSpecificFeatures.Models
{
    public class Person
    {
        public Person(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }

        public string Name { get; }
        public string LastName { get; }
    }
}
