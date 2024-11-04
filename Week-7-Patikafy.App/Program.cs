AddAndReadPatikayf();
void AddAndReadPatikayf()
{
    IReadOnlyList<Patikafy> patikafies = new List<Patikafy>
    {
        new Patikafy { FullName = "Ajda Pekkan", Type = "Pop", ReleaseYear = 1968, SalesAlbum = 20000000 },
        new Patikafy { FullName = "Sezen Aksu", Type = "Türk Halk Müziği / Pop", ReleaseYear = 1971, SalesAlbum = 10000000 },
        new Patikafy { FullName = "Funda Arar", Type = "Pop", ReleaseYear = 1999, SalesAlbum = 3000000 },
        new Patikafy { FullName = "Sertab Erener", Type = "Pop", ReleaseYear = 1994, SalesAlbum = 5000000 },
        new Patikafy { FullName = "Sıla", Type = "Pop", ReleaseYear = 2009, SalesAlbum = 3000000 },
        new Patikafy { FullName = "Serdar Ortaç", Type = "Pop", ReleaseYear = 1994, SalesAlbum = 10000000 },
        new Patikafy { FullName = "Tarkan", Type = "Pop", ReleaseYear = 1992, SalesAlbum = 40000000 },
        new Patikafy { FullName = "Hande Yener", Type = "Pop", ReleaseYear = 1999, SalesAlbum = 7000000 },
        new Patikafy { FullName = "Hadise", Type = "Pop", ReleaseYear = 2005, SalesAlbum = 5000000 },
        new Patikafy { FullName = "Gülben Ergen", Type = "Pop / Türk Halk Müziği", ReleaseYear = 1997, SalesAlbum = 10000000 },
        new Patikafy { FullName = "Neşet Ertaş", Type = "Türk Halk Müziği / Türk Sanat Müziği", ReleaseYear = 1960, SalesAlbum = 20000000 }
    };

    // Fullname starts with 'S'
    var startsWithS = patikafies.Where(x => x.FullName
                                    .StartsWith("S")).ToList();
    Console.WriteLine("--Adı 'S' ile başlayan sanatçıların listesi--");
    foreach (var names in startsWithS)
    {
        Console.WriteLine(names.FullName);
    }

    Console.WriteLine();

    // Sales album is greater than 10 million
    var salesAlbum = patikafies.Where(x => x.SalesAlbum >= 10000000 ).ToList();
    Console.WriteLine("--Satışı 10 milyonun üzerinde olan albümlerin listesi--");
    foreach (var sales in salesAlbum)
    {
        Console.WriteLine($"Sanatçı: {sales.FullName}\n" +
                        $"Albüm satışları: {sales.SalesAlbum} Milyon");
    }

    Console.WriteLine();

    // Singers who debuted before the year 2000 and perform pop music. (List them in alphabetical order, grouped by their debut years.)
    var popSingers = patikafies.Where(x => x.ReleaseYear < 2000 && x.Type.Contains("Pop"))
                                .OrderBy(x => x.FullName)
                                    .GroupBy(x => x.ReleaseYear);
    Console.WriteLine("--2000 yılından önce çıkan ve pop müzik yapan sanatçılar--");
    foreach (var pop in popSingers)
    {
        Console.WriteLine($"Yıl: {pop.Key}");
        foreach (var singer in pop)
        {
            Console.WriteLine($"Sanatçı: {singer.FullName}");
        }
    }

    Console.WriteLine();
    // The best-selling singer
    var bestSelling = patikafies.OrderByDescending(x => x.SalesAlbum).First();
    Console.WriteLine("--En çok satan sanatçı--");
    Console.WriteLine($"Sanatçı: {bestSelling.FullName}\n" +
                        $"Albüm satışları: {bestSelling.SalesAlbum} Milyon");

    Console.WriteLine();

    // The most recently debuted singer and the earliest debuted singer.
    var mostRecent = patikafies.OrderByDescending(x => x.ReleaseYear).First();
    var earliest = patikafies.OrderBy(x => x.ReleaseYear).First();
    Console.WriteLine();
    Console.WriteLine("--En son çıkan sanatçı ve en eski çıkan sanatçı--");
    Console.WriteLine($"En son çıkan sanatçı: {mostRecent.FullName}\n" +
                        $"Çıkış yılı: {mostRecent.ReleaseYear}");

    Console.WriteLine();
    Console.WriteLine($"En yeni çıkan sanatçı: {earliest.FullName}\n" +
                        $"Çıkış yılı: {earliest.ReleaseYear}");

}



file class Patikafy
{
    public required string FullName { get; set; }
    public required string Type { get; set; }
    public long ReleaseYear { get; set; }
    public int SalesAlbum { get; set; }
}

