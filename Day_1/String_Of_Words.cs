using System;
class Words{
    static void Main(string[] args){
        Console.WriteLine("Enter some words: ");
        string wordStr = Console.ReadLine();
        string[] words = wordStr.Split(' ');
        Random rnd = new Random();
        for(int pos1 = 0; pos1 < words.Length; pos1++){
            int pos2 = rnd.Next(words.Length);
            string tmp = words
        }
    } 
}