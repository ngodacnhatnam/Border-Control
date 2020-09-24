using System;
using System.Globalization;
class hello{
    static void Main(string[] args){
        String format = "d-M-yyyy";
        Console.WriteLine("Enter your date here (format: {format}): ");
        String dateAstext = Console.ReadLine();
        
        DateTime date = DateTime.ParseExact(dateAstext, format, CultureInfo.InvariantCulture);
        
        Console.WriteLine($"{dateAstext} (format: {format}) day-of-the-week = {date.DayOfWeek}");
    }
}
