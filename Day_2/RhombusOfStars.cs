using System;

class Program{
    static void Main(string[] args){
        int size = int.Parse(Console.ReadLine());
        for(int stCount = 1; stCount <= size; stCount++){
            PrintRow(size, stCount);
        }
        for(int stCount = size - 1; stCount >= 1; stCount--){
            PrintRow(size, stCount);
        }
    }
    static void PrintRow(int figureSize, int starCount){
        for(int i = 0; i < figureSize - starCount; i++){
            Console.WriteLine(" ");
        }
        for(int col = 1; col < starCount; col++){
            Console.WriteLine("* ");
        }
        Console.WriteLine("*");
    }
}