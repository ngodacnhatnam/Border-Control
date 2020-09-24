using System;
namespace BorderControl {
    public class Citizen {

        string ID { get; set; }
        string Name { get; set; }
        string Birth { get; set; }
        int Age { get; set; }

        public Citizen(string id, string name, string birth, int age)
        {
            ID = id;
            Name = name;
            Birth = birth;
            Age = age;
        }
    }
}