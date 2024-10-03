// 1- belirli kelimelerin çıktısını al
Console.WriteLine("Merhaba");
Console.WriteLine("Nasılsın ?");
Console.WriteLine("İyiyim");
Console.WriteLine("Sen nasılsın ?");


// 2- 2 değişken ata çıktısını al
int number = 0;
string content = "Selamlarr";
Console.WriteLine
    (
    $"İlk değişken: {number} \n" +
    $"İkinci değişken: {content}"
    );


// 3- random bir sayı üret ekrana bas
var random = new Random();
var GeneratedNumber = random.Next(100);
Console.WriteLine($"Random sayı: {GeneratedNumber}");


// 4- random bir sayı üret ve 3 e bölümünden kalanını bul ekrana bas
var random2 = new Random();
long GeneratedNumber2 = random2.Next(1, 100);
Console.WriteLine($"Üretilen sayı: {GeneratedNumber2}");
var result = GeneratedNumber2 % 3;
Console.WriteLine($"Sonuç: {result}");


// 5- Kullanıcıya yaşını sor ve ona göre gerekli cevabı ver.
long age;
Console.WriteLine("Yaşınızı girin");
age = long.Parse(Console.ReadLine());

if (age < 18)
{
    Console.WriteLine("-");
}

else
{
    Console.WriteLine("+");
}


// 6- 10x vodafone vs tukcell
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Sen Vodafone gibi anı yaşarken , ben Turkcell gibi seni her yerde çekemem.");
}


// 7- kullanıcıdan 2 tane string değer al ve yerlerini değiştir.
Console.WriteLine("İlk metinsel değeri girin:");
string firstInput = Console.ReadLine();

Console.WriteLine("İkinci metinsel değeri girin:");
string secondInput = Console.ReadLine();

SwapNames(ref firstInput, ref secondInput);

Console.WriteLine($"\nDeğiştirilmiş isimler:");
Console.WriteLine($"İlk isim: {firstInput}");
Console.WriteLine($"İkinci isim: {secondInput}");

static void SwapNames(ref string name1, ref string name2)
{
    string temp = name1;
    name1 = name2;
    name2 = temp;
}


// 8- Değer döndürmeyen ismi BenDegerDondurmem olan bir metot tanımla ve ekrana yazdır
void ImNotReturnValue()
{
    Console.WriteLine("Ben değer döndürmem , benim bir karşılığım yok , beni değişkene atamaya çalışma");
}

ImNotReturnValue();


// 9- İki sayıyı alıp bunların toplam değerini geriye döndüren bir metot yaz
var total = Calculator(2, 2);
Console.WriteLine(total);
static int Calculator(int number1, int number2)
{
    return number1 + number2;
}


// 10- Kullanıcıdan true ya da false değeri alıp string bir değer dönen bir metot tanımla

Console.WriteLine("Lütfen true ya da false değeri girin:");
string userInput = Console.ReadLine();
string result2 = GetStringFromBool(userInput);
Console.WriteLine($"Dönen string: {result2}");

static string GetStringFromBool(string input)
{
    bool parsedValue;
    if (bool.TryParse(input, out parsedValue))
    {
        if (parsedValue)
            return "Kullanıcı true değerini girdi.";
        else
            return "Kullanıcı false değerini girdi.";
    }
    else
    {
        return "Geçerli bir true ya da false değeri girmediniz.";
    }
}


// 11- 3 Kişinin yaşlarını alıp en yaşlı olanının yaş bilgisini dönen bir metot yaz

var result3 = ReturnOldAge();
Console.WriteLine($" En yaşlı olan: {result3}");

static long ReturnOldAge()
{
    long age1, age2, age3;

    Console.WriteLine("1. kişinin yaşını girin");
    age1 = long.Parse(Console.ReadLine());

    Console.WriteLine("2. kişinin yaşını girin");
    age2 = long.Parse(Console.ReadLine());

    Console.WriteLine("3. kişinin yaşını girin");
    age3 = long.Parse(Console.ReadLine());

    long oldAge = age1;

    if (age2 > oldAge)
    {
        oldAge = age2;
    }

    if (age3 > oldAge)
    {
        oldAge = age3;
    }
    return oldAge;
}


// 12- Kullanıcıdan sınırsız sayıda sayı alıp , bunlardan en büyüğünü ekrana yazdıran ve aynı zamanda geriye dönen bir metot yaz

long bigNumber = FindBigNumber();
Console.WriteLine($"Girilen sayının en büyüğü: {bigNumber}");

static long FindBigNumber()
{
    long[] numbers = new long[0];
    string input;
    int count = 0;

    do
    {
        Console.WriteLine("Bir sayı girin çıkmak için 'q' tuşlayın");
        input = Console.ReadLine();

        if (input.ToLower() == "q")
        {
            Environment.Exit(0);
        }

        if (long.TryParse(input, out long number))
        {
            Array.Resize(ref numbers, count + 1);
            numbers[count] = number;
            count++;
        }
        else
        {
            Console.WriteLine("Geçersiz bir sayı girdiniz lütfen tekrar deneyin.!");
        }

    } while (true);

    if (numbers.Length == 0)
    {
        Console.WriteLine("Hiç sayı girilmedi.");
        return 0;
    }

    long bigNumber = numbers[0];
    foreach (var num in numbers)
    {
        if (num > bigNumber)
        {
            bigNumber = num;
        }
    }
    return bigNumber;
}


// 13- Bir metot yardımıyla kullanıcıdan alınan 2 ismin yerlerini değiştiren uygulamayı yaz

Console.WriteLine("Adını gir");
string firstName = Console.ReadLine();

Console.WriteLine("Soy adını gir");
string lastName = Console.ReadLine();

SwapNames2(ref firstName, ref lastName);
Console.WriteLine($"değişen adınız {firstName}");
Console.WriteLine($"değişen soy adınız {lastName}");

static void SwapNames2(ref string name1, ref string name2)
{
    string swap = name1;
    name1 = name2;
    name2 = swap;
}


// 14- Kullanıcıdan alınan sayının tek mi yoksa çift mi olduğu bilgisini (true/false) dönen bir metot yaz

var result4 = TrueOrFalse();
Console.WriteLine($"Sonuç: {result4}");

static bool TrueOrFalse()
{
    Console.WriteLine("bir sayı girin");
    var number = long.Parse(Console.ReadLine());

    if (number % 2 == 0)
    {
        return true;
    }
    else
    {
        return false;
    }
}


//15 - Kullanıcıdan alınan hız ve zaman bilgileriyle , gidilen yolu hesaplayan bir metot yaz

Console.WriteLine("Hızı girin km/s");
double speed = double.Parse(Console.ReadLine());
Console.WriteLine("Zamanı girin saat olarak");
double time = double.Parse(Console.ReadLine());

double distance = CalculateDistance(speed, time);
Console.WriteLine($"Gidilen yol : {distance} km");
static double CalculateDistance(double speed, double time)
{
    return speed * time;
}


// 16 - Yarıçap bilgisi verilen bir dairenin alanını hesaplayan bir metot yaz

Console.WriteLine("Dairenin yarı çapını gir");
double radius = double.Parse(Console.ReadLine());

double area = CalculateCircleArea(radius);
Console.WriteLine($"Dairenin alanı: {area}");

static double CalculateCircleArea(double radius)
{
    return Math.PI * radius * radius;
}


// 17 - "Zaman bir GeRi SayIm" cümlesini alıp, hepsi büyük harf ve hepsi küçük harfle yazdırınız.

string content2 = "Zaman bir GeRi SayIm";
string bigContent = content2.ToUpper();
string littleContent = content2.ToLower();

Console.WriteLine($"Büyük harf ile : {bigContent}");
Console.WriteLine($"küçük harf ile : {littleContent}");


// 18 - "    Selamlar   " metnini bir değişkene atayıp , başındaki ve sonundaki boşlukları sil

string hello = "    Selamlar   ";
Console.WriteLine(hello.Trim());