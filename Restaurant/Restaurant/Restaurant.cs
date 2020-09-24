using System;
namespace Restaurant {
    public class Restaurant {

        //instance variables
        private string name;
        private string address;
        private double gratuityRate;

        //properties
        public string Name
        {
            get { return name; }
            set { name = value; }
        } // end of property

        public string Address
        {
            get { return address; }
            set { address = value; }
        } // end of property

        public double GratuityRate
        {
            get { return gratuityRate; }
            set
            {
                if(value >= 0)
                {
                    gratuityRate = value;
                }
            } // end of set
        } // end of property

        // constructor
        public Restaurant(string name, string address, double gratuityRate)
        {
            Name = name;
            Address = address;
            GratuityRate = gratuityRate;
        } // end of constructor

        public void GenerateReceipt()
        {
            double price = 0;
            double subtotal = 0;
            double gratuityAmount = 0;
            double grandTotal = 0;
            int people = 0;



            while (price != -1)
            {
                subtotal = subtotal + price;
                Console.Write("Enter price of food item: [-1 to quit]");
                price = Convert.ToDouble(Console.ReadLine());
            }

            Console.WriteLine("How many people in the party: ");
            people = Convert.ToInt32(Console.ReadLine());

            if (people >= 6)
            {
                gratuityAmount = subtotal * gratuityRate;
            }

            grandTotal = subtotal + gratuityAmount;

            Console.WriteLine("Subtotal: {0:C2} ", subtotal);
            Console.WriteLine("{0:P} Gratuity: {1:C2}", gratuityRate, gratuityAmount);
            Console.WriteLine("Gradntotal: {0:C2}", grandTotal);
        } // end of method
    }
}
