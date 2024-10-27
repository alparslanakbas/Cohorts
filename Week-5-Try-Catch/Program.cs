try
{
    Console.Write("Karesini öğrenmek istediğiniz rakamı girin: ");
    double number = double.Parse(Console.ReadLine());
    Console.WriteLine($"{number} sayısının karesi: " + Math.Pow(number,2));
}
catch (FormatException ex)
{
    Console.WriteLine($"Geçersiz giriş! Lütfen bir sayı giriniz. Hata: {ex}");
}