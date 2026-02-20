using System;

public class Program {
    public static void PrintNTimes(string message, int n) {
        // Write your code here
        for (int i = 0; i < n; i++){
            Console.WriteLine(message);
        }
    }
    
    public static void Main(string[] args) {
        string msg = Console.ReadLine();
        int n = int.Parse(Console.ReadLine());

        PrintNTimes(msg, n);
    }
}