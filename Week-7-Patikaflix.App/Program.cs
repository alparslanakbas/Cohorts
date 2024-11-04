
// Comedy series list
ComedySeries();

Console.WriteLine("\n*****_________*******\n");

// Add new seris in console
AddNewSeries();

#region ComedySeries
void ComedySeries()
{
    List<Series> seriesList = new List<Series>
{
    new Series { Name = "Avrupa Yakası", ProductionYear = 2004, Genre = "Komedi", BroadcastStartYear = 2004, Director = "Yüksel Aksu", Platform = "Kanal D" },
    new Series { Name = "Yalan Dünya", ProductionYear = 2012, Genre = "Komedi", BroadcastStartYear = 2012, Director = "Gülseren Buda Başkaya", Platform = "Fox TV" },
    new Series { Name = "Jet Sosyete", ProductionYear = 2018, Genre = "Komedi", BroadcastStartYear = 2018, Director = "Gülseren Buda Başkaya", Platform = "TV8" },
    new Series { Name = "Dadı", ProductionYear = 2006, Genre = "Komedi", BroadcastStartYear = 2006, Director = "Yusuf Pirhasan", Platform = "Kanal D" },
    new Series { Name = "Belalı Baldız", ProductionYear = 2007, Genre = "Komedi", BroadcastStartYear = 2007, Director = "Yüksel Aksu", Platform = "Kanal D" },
    new Series { Name = "Arka Sokaklar", ProductionYear = 2004, Genre = "Polisiye, Drama", BroadcastStartYear = 2004, Director = "Orhan Oğuz", Platform = "Kanal D" },
    new Series { Name = "Aşk-ı Memnu", ProductionYear = 2008, Genre = "Drama, Romantik", BroadcastStartYear = 2008, Director = "Hilal Saral", Platform = "Kanal D" },
    new Series { Name = "Muhteşem Yüzyıl", ProductionYear = 2011, Genre = "Tarih, Drama", BroadcastStartYear = 2011, Director = "Mercan Çilingiroğlu", Platform = "Star TV" },
    new Series { Name = "Yaprak Dökümü", ProductionYear = 2006, Genre = "Drama", BroadcastStartYear = 2006, Director = "Serdar Akar", Platform = "Kanal D" },
};

    // new list from comedy series
    var comedySeriesList = seriesList
        .Where(s => s.Genre.Contains("Komedi"))
            .Select(s => new ComedySeries { Name = s.Name, Genre = s.Genre, Director = s.Director })
        .OrderBy(s => s.Name)
        .ThenBy(s => s.Director)
        .ToList();

    Console.WriteLine("--Komedi diziler--\n");
    foreach (var series in comedySeriesList)
    {
        Console.WriteLine($"Dizinin adı: {series.Name}, Tür: {series.Genre}, Yönetmen: {series.Director}");
    }
}
#endregion
#region Add New Series
void AddNewSeries()
{
    var exampleSeris = new Series
    {
        Name = "Çukur",
        ProductionYear = 2017,
        Genre = "Drama, Aksiyon",
        BroadcastStartYear = 2017,
        Director = "Sinan Öztürk",
        Platform = "Show TV"
    };


    Console.WriteLine("\n--Yeni dizi ekle--\n" +
        "Örnek dizi çıktısı bu şekilde olmalı\n" +
        $"{exampleSeris.Name} {exampleSeris.ProductionYear} {exampleSeris.Genre} {exampleSeris.BroadcastStartYear} {exampleSeris.Director} {exampleSeris.Platform}"
        );

    List<Series> newSeriesList = new List<Series>();
    string userInput;
    do
    {
        Console.Write("Dizinin adı: ");
        string name = Console.ReadLine();

        Console.Write("Yapım yılı: ");
        int productionYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Tür: ");
        string genre = Console.ReadLine();

        Console.Write("Yayın yılı: ");
        int broadcastStartYear = Convert.ToInt32(Console.ReadLine());

        Console.Write("Yönetmen: ");
        string director = Console.ReadLine();

        Console.Write("Platform: ");
        string platform = Console.ReadLine();

        newSeriesList.Add(new Series
        {
            Name = name,
            ProductionYear = productionYear,
            Genre = genre,
            BroadcastStartYear = broadcastStartYear,
            Director = director,
            Platform = platform
        });

        Console.Write("Başka dizi eklemek ister misiniz? (evet/hayır): ");
        userInput = Console.ReadLine().ToLower();
    }
    while (userInput == "evet");

    Console.WriteLine("\n--Yeni dizi listesi--\n");
    foreach (var series in newSeriesList)
    {
        Console.WriteLine($"Dizinin adı: {series.Name}, Yapım yılı: {series.ProductionYear}, Tür: {series.Genre}, Yayın yılı: {series.BroadcastStartYear}, Yönetmen: {series.Director}, Platform: {series.Platform}");
    }
} 
#endregion
file class Series
{
    public required string Name { get; set; }
    public int ProductionYear { get; set; }
    public required string Genre { get; set; }
    public int BroadcastStartYear { get; set; }
    public required string Director { get; set; }
    public required string Platform { get; set; }
}

file class ComedySeries
{
    public required string Name { get; set; }
    public required string Genre { get; set; }
    public required string Director { get; set; }
}