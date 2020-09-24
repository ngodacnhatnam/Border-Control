using System;
using System.Collections.Generic;

namespace Encapsulation {
    class Program {
        static void Main(string[] args)
        {
            var Lines = int.Parse(Console.ReadLine());
            var persons = new List<Person>();
            for (int i = 0; i < Lines; i++)
            {
                var cmdArgs = Console.ReadLine().Split();
                var person = new Person(cmdArgs[0], cmdArgs[1], int.Parse(cmdArgs[2]));
                Person.Add(person);
            }
        }
    }
}
