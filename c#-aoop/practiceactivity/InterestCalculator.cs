Console.WriteLine("Enter principal amount: ");
double principalAmount = double.Parse(Console.Read());
Console.WriteLine("Enter rate: ");
double rate = double.Parse(Console.Read());
Console.WriteLine("Enter time: ");
int time = int.Parse(Console.Read());

Console.WriteLine("The interest is: " + (principalAmount * rate * time) / 100);