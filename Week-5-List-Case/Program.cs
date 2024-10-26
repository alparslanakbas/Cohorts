List<string> coffees = new List<string>();

for (int i = 1; i < 6; i++)
{
    Console.Write($"Kahve {i}: ");
    string coffeeName = Console.ReadLine() ?? "latte";
    coffees.Add(coffeeName);
}

Console.WriteLine();

Console.WriteLine("Kahve İsimleri");
foreach (var coffee in coffees)
{
    Console.WriteLine(coffee);
}