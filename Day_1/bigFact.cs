using System;
using System.Numerics;
class bigFact{
    static void Main(string[] args){
        Console.WriteLine("Enter your number here: ");
        int n = int.Parse(Console.ReadLine());
        int f = 1;
        for(int i = 2; i <= n; i++){
            f *= i;
        }
        Console.WriteLine("this is your factorial num: " + f);
    }
}