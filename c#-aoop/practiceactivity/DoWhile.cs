using System;

public class Program {
    public static void Main(string[] args) {
        // Initialize variables
        int sum = 0;
        int number = 1;

        // Your code here
        do {
            sum = sum + number;
            number = number + 2;
            Console.WriteLine($"Sum is: {sum}");
            Console.WriteLine($"Num is: {number}");
        } while (number <= 50);

        // Print the final sum
        Console.WriteLine("Final Sum: " + sum);
    }
}