using System;

public class Program {
    public static void Main(string[] args) {
        int n1 = int.Parse(Console.ReadLine());
        int n2 = int.Parse(Console.ReadLine());
        string op = Console.ReadLine();
        
        // Write your code below
        double result = 0;
        if (op == "+"){
            result = n1 + n2;
        } else if(op == "-"){
            result = n1 - n2;
        } else if (op == "/"){
            result = n1 / n2;
        } else if (op == "*"){
            result = n1 * n2;
        } else {
            Console.WriteLine("Error: Invalid operator");
        }
        
        
        Console.WriteLine(result);
    }
}