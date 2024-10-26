using Week_4_FinalCase;

bool keepGoing = true;
while (keepGoing)
{
    Console.WriteLine("Telefon üretmek için 1, bilgisayar üretmek için 2'ye basın:");
    string input = Console.ReadLine() ?? "";

    switch (input)
    {
        case "1":
            AddPhone();
            break;
        case "2":
            AddComputer(); 
            break;
        default:
            Console.WriteLine("Geçersiz seçim, tekrar deneyin.");
            continue; 
    }

    AgainTry:
    Console.WriteLine("Tekrar ürün eklemek için E tuşlayın veya çıkmak için 0'a basın:");
    string choice = Console.ReadLine() ?? "";

    if (choice.Equals("E", StringComparison.OrdinalIgnoreCase))
    {
        keepGoing = true;
    }
    else if (choice.Equals("0"))
    {
        keepGoing = false;
        Console.WriteLine("İyi günler!");
    }
    else
    {
        Console.WriteLine("Geçersiz seçim tekrar deneyin");
        goto AgainTry;
    }
}

void AddPhone()
{
    Console.Write("Telefon Adı: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Telefon Açıklaması: ");
    string description = Console.ReadLine() ?? "";

    Console.Write("Telefon İşletim Sistemi: ");
    string operationSystem = Console.ReadLine() ?? "";

    Console.Write("TR Lisanslı mı? Evet için E, Hayır için H yazın: ");
    string isLicenceTR = Console.ReadLine() ?? "";
    bool trLisansli = isLicenceTR.Equals("E", StringComparison.OrdinalIgnoreCase);

    Phone phone = new Phone(name, description, operationSystem, trLisansli);
    Console.WriteLine($"{name} adlı telefon başarıyla üretildi.\n");
    phone.WriteToConsolePhoneInfo();
}


void AddComputer()
{
    Console.Write("Bilgisayar Adı: ");
    string name = Console.ReadLine() ?? "";

    Console.Write("Bilgisayar Açıklaması: ");
    string description = Console.ReadLine() ?? "";

    Console.Write("Bilgisayar İşletim Sistemi: ");
    string operationSystem = Console.ReadLine() ?? "";

    Console.Write("Bluetooth özelliği var mı? (Evet için E, Hayır için H yazın): ");
    string isBluetooth = Console.ReadLine() ?? "";
    bool bluetooth = isBluetooth.Equals("E", StringComparison.OrdinalIgnoreCase);

    Console.Write("USB giriş sayısı (2 veya 4 olmalı): ");
    int usbPortCount = int.Parse(Console.ReadLine() ?? "0"); 

    Computer computer = new Computer(name, description, operationSystem, bluetooth, usbPortCount);
    Console.WriteLine($"{name} adlı bilgisayar başarıyla üretildi.\n");
    computer.WriteToConsoleComputerInfo(); 
}




