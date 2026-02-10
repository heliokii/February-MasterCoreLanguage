using System;

class Program {
    public static void Main(string[] args) {
        int age = int.Parse(Console.ReadLine()); // Don't change this line
        int height = int.Parse(Console.ReadLine()); // Don't change this line
        bool hasAdult = bool.Parse(Console.ReadLine()); // Don't change this line

        string status = "";
        
        // Write your code below
        if (age < 12) {
            Console.WriteLine("Sorry, you're too young");
        } else {
            if (height < 150) {
                Console.WriteLine("Sorry, you're not tall enough");
            } else {
                // At this point: age >= 12 AND height >= 150
                if (age >= 18) {
                    Console.WriteLine("You can ride by yourself!");
                    status = "adult";
                } else if (hasAdult == true) {
                    Console.WriteLine("You can ride with adult supervision!");
                    status = "supervised";
                } else {
                    Console.WriteLine("Sorry, you need an adult with you!");
                }
            }
        }
        
        // Don't change below this line
        Console.WriteLine(status);
    }
}