using System;

public class Program {
    public static void Main(string[] args) {
        // Write your code below
        int age = int.Parse(Console.ReadLine());
        int num = 120 - age;

        Console.WriteLine($"{num} years till 120");
    }
}