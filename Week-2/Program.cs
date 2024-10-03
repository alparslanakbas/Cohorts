//** For works **//
using System.Text;



// 10x Kendime inanıyorum --- I believe myself -_-
for (int i = 0; i < 10; i++)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
}

// 1/20 arası rakamlar 
for (int i = 1; i <= 20; i++)
{
    Console.WriteLine(i);
}

// 1/20 arası çift rakamlar
for (int i = 0; i <= 20; i += 2)
{
    Console.WriteLine(i);
}

// 50-150 arasında ki rakamların toplamı
int total = 0;
for (int i = 50; i <= 150; i++)
{
    total += i;
}
Console.WriteLine("50-150 arasında ki sayıların toplamı: " + total);

// 1-120 arasında ki tek ve çift rakamların ayrı toplamı
int PozitiveTotal = 0;
int NegativeTotal = 0;

// negatif için
for (int i = 1; i <= 120; i += 2)
{
    NegativeTotal += i;
}
Console.WriteLine("1-120 arasında ki tek sayıların toplamı: " + NegativeTotal);

//pozitif için
for (int i = 0; i <= 120; i += 2)
{
    PozitiveTotal += i;
}
Console.WriteLine("1-120 arasında ki çift sayıların toplamı: " + PozitiveTotal);


//** While works **//

// 10x Kendime inanıyorum --- I believe myself -_-
int count = 0;
while (count < 10)
{
    Console.WriteLine("Kendime inanıyorum, ben bu yazılım işini hallederim!");
    count++;
}

// 1/20 arası rakamlar
int count2 = 1;
while (count <= 20)
{
    Console.WriteLine(count2);
    count2++;
}

// 1/20 arası çift rakamlar
int count3 = 2; // İstenilen görev de 0 değil 1/20 arası sayı istendiği için 2 veriyorz. 1 verirsek tekli sayıları elde ederiz çünkü 2 2 artması gerektiğini söylüyorum.*
while (count3 <= 20)
{
    Console.WriteLine(count3);
    count3 += 2;
}

// 50-150 arasında ki rakamların toplamı
int count4 = 50;
int total2 = 0;
while (count <= 150)
{
    total2 += count4;
    count4++;
}

Console.WriteLine($"50-150 arasında ki sayıların toplamı: {total}"); // Buraya değişkeni iki farklı türde getirebiliriz. $ simgesi string ifadeler de değişkeni çağırmak için kullanıyoruz.
                                                                     // yada kullanmak istemiyorsanız + ile string ifadeden çıkıp direk değişkeni buraya getirebilirsiniz.


// 1-120 arasında ki tek ve çift rakamların ayrı toplamı
int PozitiveTotal2 = 0;
int NegativeTotal2 = 0;
int total3 = 1;

while (total3 <= 120)
{
    if (total3 % 2 == 0)
    {
        PozitiveTotal2 += total3;
    }

    else
    {
        NegativeTotal2 += total3;
    }
    total3++;
}
Console.WriteLine("1-120 arasında ki tek sayıların toplamı: " + NegativeTotal2);
Console.WriteLine("1-120 arasında ki çift sayıların toplamı: " + PozitiveTotal2);



// Pratik while vs do-while

var count5 = 1;
var limit = 15;
Console.WriteLine("Lütfen sayaç için bir rakam giriniz: ");
limit = Convert.ToInt16(Console.ReadLine());
do
{
    Console.WriteLine("Ben bir Patika'lıyım");
    count5++;
} while (count5 <= limit);


var count6 = 1;
var limit2 = 15;

Console.WriteLine("Lütfen sayaç için bir rakam giriniz: ");
limit2 = Convert.ToInt16(Console.ReadLine());
while (count6 <= limit2)
{
    Console.WriteLine("Ben bir Patika'lıyım");
    count6++;
}



// Yol arkadaşı tatil uygulaması



const string Bodrum = "Bodrum (Paket başlangıç fiyatı 4000 TL)"; // const hiçbir zaman değiştirilmeyen sabit değişken türleridir. Genellikle sql sorgularında servisler de sıklıkla kullanılır.
const string Marmaris = "Marmaris (Paket başlangıç fiyatı 3000 TL)";
const string Cesme = "Çeşme (Paket başlangıç fiyatı 5000 TL)";
const string RoadWay = "1- Kara yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 1500 TL )";
const string AirWay = "2- Hava yolu ( Kişi başı ulaşım tutarı gidiş-dönüş 4000 TL)";

int total4 = 0;
float BodrumPrice = 4000f;
float MarmarisPrice = 3000f;
float CesmePrice = 5000f;
float RoadPrice = 1500f;
float AirPrice = 4000f;

Start:
Console.WriteLine("Gitmek istediğiniz lokasyonun adını yazınız: \n" +
    $"{Bodrum} \n" +
    $"{Marmaris} \n" +
    $"{Cesme}");

var location = Console.ReadLine();

// if ile kontrol
if (
    location is null
    ||
    !location.Contains("Bodrum", StringComparison.OrdinalIgnoreCase) // Contains metodu çevirisi anlamıyla verilen değişkenin içerisin de sizin belirttiğiniz değeri arar.
    &&
    !location.Contains("Marmaris", StringComparison.OrdinalIgnoreCase) // StringComparison bir enumdur içerisinde ki özelliklere f12 ile bakabilirsiniz. bu özellik her türlü harf duyarlılığını ortadan kaldırır.
    &&
    !location.Contains("Çeşme", StringComparison.OrdinalIgnoreCase)
   )
{
    Console.WriteLine("Lokasyon adını yanlış yazdınız lütfen tekrar deneyiniz.!");
    goto Start;
}

Console.WriteLine(); // boş satır verelim çok yazı karışıklık yaratmasın konsolda

Console.WriteLine($"Gitmek istediğiniz lokasyon {location} olarak belirlenmiştir.. İlgili lokasyonun sistemine yönlendiriliyorsunuz lütfen bekleyiniz...");
await Task.Delay(3000);  // 3 saniye delay yani süre veriyoruz maksat can sıkıntısı (müşteri hizmetleri yeri gelir 10 dakika bekletir) :D

Console.WriteLine();

Console.WriteLine($"{location} tatili için planınız kaç kişi ?");
int countPeople = Convert.ToInt16(Console.ReadLine());

Console.WriteLine($"{location} lokasyonu için {countPeople} kişilik yeriniz onaylanmıştır. \n" +
    "Böylesine müthiş bir coğrafyanın tadını sessiz ve sakin bir ortamda, sevdiklerinizle birlikte çıkarabilirsiniz. \n" +
    "Gidiş seçeneklerinizi seçeceksiniz lütfen bekleyiniz...");
await Task.Delay(3000);

Console.WriteLine();

RoadMap:
Console.WriteLine("2 Seçeneğimiz var bütçesine göre 1 veya 2 seçeneklerini seçiniz: \n" +
    $"{RoadWay} \n" +
    $"{AirWay}");
var WayType = Console.ReadLine();

// while ile kontrol
while (
        !WayType!.Contains("1") // Sonuna ünlem koyarak string ifadelerin null olmamasını sağlarsınız eğer ? işareti koyarsanız o değişken null da olabilir demek istemiş olursunuz.
        &&
        !WayType.Contains("2")
      )
{
    Console.WriteLine("Seçeneklerimizden birini seçmediniz tekrar deneyiniz!");
    goto RoadMap;
}

StringBuilder sb = new StringBuilder(); // String builder genelde c# da dinamik html kodları yazmak için tercih edilir. amacı string ifadeleri birleştirmek.

if (WayType.Contains("1"))
{
    WayType = sb.Append("Kara yolu").ToString();
    total4 = countPeople * Convert.ToInt16(RoadPrice);
}

else if (WayType.Contains("2"))
{
    WayType = sb.Append("Hava yolu").ToString();
    total4 = countPeople * Convert.ToInt16(AirPrice);
}

Console.WriteLine();
if (location.Contains("Bodrum", StringComparison.OrdinalIgnoreCase))
{
    total4 += Convert.ToInt16(BodrumPrice) * countPeople;
}
else if (location.Contains("Marmaris", StringComparison.OrdinalIgnoreCase))
{
    total4 += Convert.ToInt16(MarmarisPrice) * countPeople;
}
else if (location.Contains("Çeşme", StringComparison.OrdinalIgnoreCase))
{
    total4 += Convert.ToInt16(CesmePrice) * countPeople;
}

Console.WriteLine();
Console.WriteLine($"{location} için {countPeople} kişi {WayType} aracı ile toplam fiyat tutarı : {total4} TL'dir. Ödeme gerçekleşiyor lütfen bekleyiniz...");
await Task.Delay(3000);

Console.WriteLine();

// do while ile kontorl
do
{
    Console.WriteLine("Başka bir tatil planına ihtiyacınız var ise lütfen 1, çıkmak için lütfen 0 seçeneklerini giriniz: ");
    var choose = Console.ReadLine();

    if (choose!.Contains("1"))
    {
        goto Start;
    }

    else
    {
        Console.WriteLine("İyi günker");
        Console.ReadKey();
    }
}
while (true);



// Useful Functions ////

using Week_2;

HelperFunctions helperFunctions = new HelperFunctions(); // Fonksiyonlarımı tanımlayabileceğim bir yardımcı sınıf oluşturuyorum.

// Müzik sözü
helperFunctions.SongLyrics();


//******//

// Random sayı üret kalanı çift olsun
helperFunctions.RandomGenerateNumber();
var number = helperFunctions.RandomGenerateNumber();
Console.WriteLine($"2 ye bölümünden kalan: {number}");


//******//

// değer verip çarpma işlemi yaptır
var result = helperFunctions.Calculator(10, 5);
Console.WriteLine($"Sonuç: {result}");


//******//

// Welcome Mr ?
helperFunctions.WelcomeMr("Alparslan", "Akbaş");




