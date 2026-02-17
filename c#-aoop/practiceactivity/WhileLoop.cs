using System;

public class Program {
    public static void Main(string[] args) {
        // Write your code below
        double input = double.Parse(Console.ReadLine());
        while (input >= 3.5){
            input = input / 2;
        }
        Console.WriteLine(input);
    }
}