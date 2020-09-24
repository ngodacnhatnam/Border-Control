using System;

namespace Restaurant {
    class Program {
        static void Main(string[] args)
        {
            Restaurant obj = new Restaurant("Dairy Queen", "123 Main", .15);
            Console.WriteLine("{0}", obj.Name);
            Console.WriteLine("{0}", obj.Address );
            obj.GenerateReceipt();
        }
    }
}
