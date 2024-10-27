using Week_5_ImdbApp;

List<Film> filmList = new List<Film>();
bool keepGoing = true;

while (keepGoing)
{
    AddFilm(filmList);
    RollBack:
    Console.Write("Yeni bir film eklemek istiyorsanız lütfen e tuşlayın, çıkış için h: ");
    string answer = Console.ReadLine() ?? "h";

    if (!answer.Equals("h", StringComparison.OrdinalIgnoreCase) || answer.Equals("e", StringComparison.OrdinalIgnoreCase))
    {
        
        Console.WriteLine("Geçersiz, lütfen sadece 'e' veya 'h' tuşlayın.");
        goto RollBack;
    }

    keepGoing = answer.Equals("e", StringComparison.OrdinalIgnoreCase);
}

Film.ListAllFilms(filmList);
Film.FilterByImdb(filmList);
Film.FilterByName(filmList);

static void AddFilm(List<Film> filmList)
{
    Console.Write("Eklemek istediğiniz filmin adını giriniz: ");
    string name = Console.ReadLine() ?? "Interstellar";

    double imdb;
    while (true)
    {
        Console.Write($"{name} adlı filmin IMDB puanını giriniz: ");
        if (double.TryParse(Console.ReadLine(), out imdb))
        {
            break;
        }
        else
        {
            Console.WriteLine("Lütfen geçerli bir IMDB puanı giriniz.(Örnek- 9,5) ");
        }
    }

    Film film = new Film(name, imdb);
    filmList.Add(film);

    Console.WriteLine();
    Console.WriteLine($"Film Eklendi => Adı: {film.Name}, IMDB Puanı: {film.Imdb}\n");
}


