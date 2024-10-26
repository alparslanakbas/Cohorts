List<string> invitees = new List<string>
{
    "David Guetta", "Martin Garrix", "Armin van Buuren", "Tiësto", "Calvin Harris",
    "Dimitri Vegas & Like Mike", "Afrojack", "Skrillex", "Steve Aoki", "Marshmello"
};

foreach (var (name, index) in invitees.Select((name, index) => (name, index + 1)))
{
    Console.WriteLine($"{index}- {name}");
}