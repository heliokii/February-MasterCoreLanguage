using System;

public class Program {
    public static double Bigger(double arg1, double arg2) {
        // Complete the method
        if (arg1 > arg2){
            return arg1;
        } else {
            return arg2;
        }
    }

    public static void Main(string[] args) {
        int iterations = int.Parse(Console.ReadLine());
        double num1 = double.Parse(Console.ReadLine());
        double num2 = double.Parse(Console.ReadLine());

        for (int i = 0; i < iterations; i++) {
            // Write your code below
            double bigger = Bigger(num1, num2);
            if (num1 >= num2){
                num1 = num1 / 2;
                Console.WriteLine(num1);
            } else {
                num2 = num2 / 2;
                Console.WriteLine(num2);
            }
            if (num1 < 2 || num2 < 2){
                break;
            }
        }
        
    }
}