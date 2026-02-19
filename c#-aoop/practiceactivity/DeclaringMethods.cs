using System;

public class Program {
    // Method declaration
    public static void SumNumbers() {
        // Complete Method
        int sum = 0;
        for (int i = 0; i <= 1000; i++){
            sum += i;
        }
        Console.WriteLine(sum);
    }
    
    
    public static void Main(string[] args) {
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++) {
            // Call the method n times
            SumNumbers();
        }
    }
}