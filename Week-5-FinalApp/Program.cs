using Week_5_FinalApp;

List<Car> cars = new List<Car>();
bool keepGoing = true;

while (keepGoing)
{
    Console.Write("Araba üretmek istiyor musunuz ? evet için e hayır için h tuşlayınız.. (e/h): ");
    string answer = Console.ReadLine() ?? "";

    if (answer.Equals("e", StringComparison.OrdinalIgnoreCase))
    {
        Add(cars);
    }
    else if (answer.Equals("h", StringComparison.OrdinalIgnoreCase))
    {
        keepGoing = false;
    }
    else
    {
        Console.WriteLine("Geçersiz giriş, lütfen 'e' veya 'h' giriniz.");
    }
}

Console.WriteLine("\nOluşturulan Arabalar:");
foreach (var car in cars)
{
    Console.WriteLine($"Seri numarası: {car.SerialNumber}, Marka: {car.Marka}");
}
        

static void Add(List<Car> cars)
{
    Console.Write("Marka: ");
    string marka = Console.ReadLine() ?? "";

    Console.Write("Model: ");
    string model = Console.ReadLine() ?? "";

    Console.Write("Renk: ");
    string color = Console.ReadLine() ?? "";

    DoorCount:
    int doorCount;
    try
    {
        Console.Write("Kapı Sayısı: ");
        doorCount = int.Parse(Console.ReadLine() ?? "");
    }
    catch (FormatException)
    {
        Console.WriteLine("Geçersiz kapı sayısı, lütfen rakam giriniz.");
        goto DoorCount;
    }

    Car newCar = new Car(marka, model, color, doorCount);
    cars.Add(newCar);

    Console.WriteLine("Araba başarıyla eklendi!\n");
}