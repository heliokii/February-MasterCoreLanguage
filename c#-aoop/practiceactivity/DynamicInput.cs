using System;

public class Program {
    public static void Main(string[] args) {
        int count = int.Parse(Console.ReadLine());
        // Write your code below
        int total = 0;
        for (int i = 0; i < count; i++){
            int value = int.Parse(Console.ReadLine());
            total += value;
        }
        Console.WriteLine(total);
    }
}