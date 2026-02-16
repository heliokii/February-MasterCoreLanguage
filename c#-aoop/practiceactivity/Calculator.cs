using System;

public class Program {
    public static void Main(string[] args) {
        Console.WriteLine("Calculator App");
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());
        Console.WriteLine($"Sum: {(num1 + num2):F2}");
        Console.WriteLine($"Difference: {(num1 - num2):F2}");
        Console.WriteLine($"Product: {(num1 * num2):F2}");
        Console.WriteLine($"Quotient: {(num1 / num2):F2}");
    }
}