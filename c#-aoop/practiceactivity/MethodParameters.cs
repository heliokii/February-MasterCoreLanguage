using System;

public class Program {
    // Method declaration
    public static void CalculateProduct(int num1, int num2){
        Console.WriteLine($"{num1 * num2}");
    }
    
    public static void Main(string[] args) {
        int a = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        // Call the method with a and b as arguments
        
        CalculateProduct(a, b);
    }
}