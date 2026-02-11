using System;

class Program {
    public static void Main(string[] args) {
        int age = int.Parse(Console.ReadLine()); // Don't change this line
        int height = int.Parse(Console.ReadLine()); // Don't change this line
        bool hasAdult = bool.Parse(Console.ReadLine()); // Don't change this line

        string status = "";
        
        // Write your code below
        if (age < 12) {
            status = "Sorry, you're too young";
        } else if (height <= 150) { 
            status = "Sorry, you're not tall enough";
        } else {
            if (age < 15) {
                if (hasAdult) {
                    status = "You can ride with adult supervision!";
                } else {
                    status = "Sorry, you need an adult with you";
                }
            } else {
                status = "You can ride by yourself!";
            }
        }
        
        // Don't change below this line
        Console.WriteLine(status);
    }
}
