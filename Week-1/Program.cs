
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
Name =Console.ReadLine();

Console.WriteLine("Soyad:");
Surname =Console.ReadLine();

Console.WriteLine("Telefon Numarası:");
MobilPhone =(Console.ReadLine());

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






