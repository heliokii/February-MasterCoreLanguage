using System;

public class Program {
    public static void Main(string[] args) {
        int number = int.Parse(Console.ReadLine());
        string result = "";
        
        result = (number > 0) ? "positive": (number < 0) ? "negative" : "zero";
        
        Console.WriteLine("The number is " + result);
    }
}