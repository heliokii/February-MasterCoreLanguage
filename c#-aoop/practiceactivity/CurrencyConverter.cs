Console.WriteLine("Enter amount in USD: ");
double amount = double.Parse(Console.ReadLine());
Console.WriteLine("Enter exchange rate from USD to EUR: ");
double exchangeRate = double.Parse(Console.ReadLine());
Console.WriteLine("The amount in EUR is: " + (amount * exchangeRate));