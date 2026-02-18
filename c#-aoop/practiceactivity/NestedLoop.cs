using System;

public class Program {
    public static void Main(string[] args) {
        int width = int.Parse(Console.ReadLine());
        int height = int.Parse(Console.ReadLine());
        // Write your code below
        for(int i = 0; i < height; i++){
            for (int j = 0; j < width; j++){
                Console.Write("*");
            }
        Console.WriteLine();
        }
    }
}