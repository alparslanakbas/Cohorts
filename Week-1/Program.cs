
// Ad-Soyad ve Patikaya neden katıldığımın çıktısı
string UserName = "Alparslan Akbaş";
string PaticaContent = "Patika da yer alma sebebim referans aracılığıyla güzel bir yazılım şirketine veya hayalim deki şirkete yerleşip profesyonel olarak kariyer inşa etmek..";

Console.WriteLine(UserName);
Console.WriteLine(PaticaContent);

// Değişkenler ile uygulama

;
string Name, Surname, IdentityId, MobilPhone, Age;
float FirstPrice, LastPrice;


Console.WriteLine("Lütfen aşağıda ki bilgileri giriniz:");

Console.WriteLine("TC Kimlik numarası:");
IdentityId = Console.ReadLine();

Console.WriteLine("Ad:");
Name = Console.ReadLine();

Console.WriteLine("Soyad:");
Surname = Console.ReadLine();

Console.WriteLine("Telefon Numarası:");
MobilPhone = (Console.ReadLine());

Console.WriteLine("Yas:");
Age = (Console.ReadLine());

Console.WriteLine("Ilk aldığı ürünün fiyatı:");
FirstPrice = int.Parse(Console.ReadLine());

Console.WriteLine("Ikinci aldığı ürünün fiyati:");
LastPrice = int.Parse(Console.ReadLine());

Console.WriteLine(IdentityId + "TC numarali " + Name + " " + Surname + " " + "isimli kişi için kayıt oluşturulmuştur.");
Console.WriteLine(MobilPhone + " telefon numarasına bildirim mesajı gönderilmiştir.");

float Total = FirstPrice + LastPrice;
float Earn = Total * 0.10f;

Console.WriteLine(Total + " toplam harcama karşılığı kazanılan %10 patika puan miktarı -> " + Earn);

// Telefon numarası için string tercih ettim çünkü integer 32 bitlik bir sayı türüdür yani belli aralıklar arası değer tutuabilir ayrıca gerçek hayatta da bir çok yerde string türünde tutulur.
// Ürün fiyatları ve kazançları float olarak tutuyorum. Genelde fiyat float veya decimal olarak tutulur bu yazılımcının tercihine kalmış ben float olarak tutmak istedim.

// Practice If-Else

int Number;
int Limit = 10;
string PozitiveMessage = "Girilen sayı çifttir";
string NegativeMessage = "Girilen sayı tektir.";

Console.WriteLine("Lütfen bir sayı giriniz: ");
Number = int.Parse(Console.ReadLine());

if (Number > Limit)
{
    Console.WriteLine("Girilen sayı 10'dan büyüktür.");
    if (Number % 2 == 0)
    {
        Console.WriteLine(PozitiveMessage);
    }

    else
    {
        Console.WriteLine(NegativeMessage);
    }
}

else if (Number == Limit)
{
    Console.WriteLine("Girilen sayı eşittir.");
    if (Number % 2 == 0)
    {
        Console.WriteLine(PozitiveMessage);
    }

    else
    {
        Console.WriteLine(NegativeMessage);
    }
}

else if (Number < Limit)
{
    Console.WriteLine("Girilen sayı 10'dan küçüktür.");
    if (Number % 2 == 0)
    {
        Console.WriteLine(PozitiveMessage);
    }

    else
    {
        Console.WriteLine(NegativeMessage);
    }
}


// Practice if-else / switch-case

int Choose = 0;

Start:
Console.WriteLine("Rüya manavına hoş geldiniz, işleminize hangi seçenek ile devam etmek istersiniz ? \n" +
    "If Else ile devam etmek için 1\n" +
    "Switch Case ile devam etmek için 2");
Choose =int.Parse(Console.ReadLine());

if (Choose == 1)
{
    goto IfElse;
}

else if (Choose == 2)
{
    goto Switch;
}

else
{
    Console.WriteLine("Lütfen belirtilen değerler haricinde bir rakam girmeyin");
    goto Start;
}


IfElse:
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
string ChooseIf = Console.ReadLine().ToLower();

if (ChooseIf == "elma")
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
else if (ChooseIf == "armut")
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
else if (ChooseIf == "çilek")
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
else if (ChooseIf == "muz")
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
else
    Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");


Switch:
Console.WriteLine("Rüya Manavına Hoş Geldiniz!");
Console.WriteLine("Elma = 2 TL");
Console.WriteLine("Armut = 3 TL");
Console.WriteLine("Çilek = 2 TL");
Console.WriteLine("Muz = 3 TL");
Console.WriteLine("Diğer bütün meyveler = 4 TL");

Console.Write("Hangi meyveyi satın almak istersiniz? (Elma/Armut/Çilek/Muz/Diğer): ");
string ChooseSwitch = Console.ReadLine().ToLower();

switch (ChooseSwitch)
{
    case "elma":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "armut":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    case "çilek":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 2 TL");
        break;
    case "muz":
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 3 TL");
        break;
    default:
        Console.WriteLine("Seçtiğiniz meyvenin fiyatı: 4 TL");
        break;
}


// Küçük bir işlem olduğu için bence if ile yapmak daha basit gibi geliyor (tercihen). Ama genel olarak baktığımızda 2 yapının da kullanımı her zaman projenin seyrine göre belirlenir.







