using Week_5_ImdbApp;

        List<Film> filmList = new List<Film>();
        bool keepGoing = true;

        while (keepGoing)
        {
            AddFilm(filmList);

            Console.Write("Yeni bir film eklemek istiyorsanız lütfen e tuşlayın, çıkış için h");
            string answer = Console.ReadLine() ?? "";
            keepGoing = answer.Equals("E", StringComparison.OrdinalIgnoreCase);
        }

        // Tüm filmleri listele
        Console.WriteLine("Tüm Filmler:");
        foreach (var film in filmList)
        {
            Console.WriteLine($"Film Adı: {film.Name}, Imdb Puanı: {film.Imdb}");
        }

        // Imdb puanı 4 ile 9 arası filmleri listele
        Console.WriteLine("Imdb Puanı 4 ile 9 Arasında Olan Filmler:");
        var filterFilmByImdb = filmList.Where(f => f.Imdb >= 4 && f.Imdb <= 9);
        foreach (var film in filterFilmByImdb)
        {
            Console.WriteLine($"Film Adı: {film.Name}, Imdb Puanı: {film.Imdb}");
        }

        // İsmi a ile başlayan fimleri listele
        Console.WriteLine("İsmi 'A' ile Başlayan Filmler:");
        var filterFilmByName = filmList.Where(f => f.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));
        foreach (var film in filterFilmByName)
        {
            Console.WriteLine($"Film Adı: {film.Name}, Imdb Puanı: {film.Imdb}");
        }

    static void AddFilm(List<Film> filmList)
    {
        Console.Write("Eklemek istediğiniz filmin adını gir: ");
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
                Console.WriteLine("Lütfen geçerli bir IMDB puanı giriniz.(Örnek- 10,0) ");
            }
        }

        Film film = new Film(name, imdb);
        filmList.Add(film);

        Console.WriteLine($"Film Eklendi -> Adı: {film.Name}, IMDB Puanı: {film.Imdb}\n");
    }


