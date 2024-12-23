﻿int[] naturalNumbers = new int[10];

for (int i = 0; i < 10; i++)
{
    naturalNumbers[i] = i;
}

Console.Write("Bir sayı ekle: ");
int newValue = int.Parse(Console.ReadLine() ?? "0");

Array.Resize(ref naturalNumbers, 11);
naturalNumbers[10] = newValue;



int total = 0;
foreach (int i in naturalNumbers)
{
    total += i;
}

Console.WriteLine($"Sayıların toplamı: {total}");


// string join ifadesi 2 değer alır amacı dizide ki verileri belirtilen bi ifadeyle ayırmaktır. ilk istediği değerde nasıl ayırmak istiyorsunuz onu girin
// 2. değer ise dizinizin bulunduğu değişkeni.. linq sorugusuyla basit yoldan sıralama yapın
Console.WriteLine("Büyükten küçüğe: " + String.Join("-", naturalNumbers.OrderByDescending(x => x)));