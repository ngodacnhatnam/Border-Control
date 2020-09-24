using System;
namespace Encapsulation {
    public class Person {
        public string Firstname { get; private set; }
        public string Lastname { get; private set; }
        public int Age { get; private set; }
        
        public Person(string firstName, string lastName, int age)
        {
            this.Firstname = firstName;
            this.Lastname = lastName;
            this.Age = age;
        }
        public override string ToString()
        {
            return $"{this.FirstName} {this.LastName} is {this.Age} yearsold.";
        }
    }
}
