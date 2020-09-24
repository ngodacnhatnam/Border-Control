/*using System;
namespace Hotel_rev
{
    class ProgHoteReserve
    {
        public static void Run(string[] args)
        {
            Console.WriteLine("Enter reservation info here: {pricePerDay} {numberOfDays} {season} {discountType}");

            string[] input = Console.ReadLine().Split(" ");
            decimal pricePerDay = decimal.Parse(input[0]);
            int numberOfDays = int.Parse(input[1]);
            Season season = (Season)Enum.Parse(typeof(Season), input[2]);
            Discount discount;
            if (input.Length > 3)
            {
                discount = (Discount)Enum.Parse(typeof(Season), input[2]);
            }
            else
            {
                discount = Discount.None;
            }

            decimal totalPrice = PriceCalculator.CalculatePrice(pricePerDay, numberOfDays, season, discount);
            String totalPriceF = string.Format("{0:0:00}", totalPrice);
            Console.WriteLine($"Total price: {totalPriceF}");
        }
    }
}
*/