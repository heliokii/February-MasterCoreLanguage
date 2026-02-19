using System;

class Pentagon
{
    private double side;

    public Pentagon()
    {
        side = 0.0;
    }

    public Pentagon(double sideLength)
    {
        side = sideLength;
    }

    public double GetPerimeter()
    {
        return 5 * side;
    }

    public double GetArea()
    {
        double sqrt5 = Math.Sqrt(5.0);
        double inner = 5.0 + 2.0 * sqrt5;
        double constant = Math.Sqrt(inner) / 4.0;
        return constant * side * side;
    }

    public void Display()
    {
        Console.WriteLine($"Side length: {side:F3}");
        Console.WriteLine($"Perimeter : {GetPerimeter():F3}");
        Console.WriteLine($"Area : {GetArea():F3}");
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Pentagon p1");
        Console.WriteLine("-------------------------");
        Pentagon p1 = new Pentagon();
        p1.Display();

        Console.WriteLine("Pentagon p2");
        Console.WriteLine("-------------------------");
        Pentagon p2 = new Pentagon(5.0);
        p2.Display();

        Console.WriteLine("Pentagon p3");
        Console.WriteLine("-------------------------");
        Pentagon p3 = new Pentagon(3.2);
        p3.Display();

        Console.WriteLine("Press any key to close...");
        Console.ReadKey();
    }
}