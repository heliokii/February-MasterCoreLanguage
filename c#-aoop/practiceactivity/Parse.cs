using System;

public class Program {
    public static void Main(string[] args) {
        string firstNumberString = Console.ReadLine();
        string secondNumberString = Console.ReadLine();

        // Use Parse to convert the numbers
        int firstNumber = int.Parse(firstNumberString);
        int secondNumber = int.Parse(secondNumberString);
        
        // Calculate the sum
        int sum = firstNumber + secondNumber;
        
        // Print the sum of the numbers
        Console.WriteLine(sum);
    }
}