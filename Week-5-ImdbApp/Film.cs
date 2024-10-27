namespace Week_5_ImdbApp
{
    public class Film
    {
        public string Name { get; set; }
        public double Imdb { get; set; }

        public Film(string name, double imdb)
        {
            Name = name;
            Imdb = imdb;
        }


        public static void ListAllFilms(List<Film> filmList)
        {
            Console.WriteLine("--Tüm Filmler--");

            foreach (var film in filmList)
            {
                Console.WriteLine($"Film Adı: {film.Name}, Imdb Puanı: {film.Imdb}");
            }

            Console.WriteLine();
        }

        public static void FilterByImdb(List<Film> filmList)
        {
            Console.WriteLine("Imdb puanı 4 ile 9 arasında olan filmler:");
            var filteredFilms = filmList.Where(f => f.Imdb >= 4 && f.Imdb <= 9);

            foreach (var film in filteredFilms)
            {
                Console.WriteLine($"Film Adı: {film.Name}, Imdb Puanı: {film.Imdb}");
            }

            Console.WriteLine();
        }

        public static void FilterByName(List<Film> filmList)
        {
            Console.WriteLine("İsmi A ile başlayan filmler:");
            var filteredFilms = filmList.Where(f => f.Name.StartsWith("A", StringComparison.OrdinalIgnoreCase));

            if (!filteredFilms.Any())
            {
                Console.WriteLine("A ile başlayan film yoktur");
            }
            else
            {
                foreach (var film in filteredFilms)
                {
                    Console.WriteLine($"Film Adı: {film.Name}, Imdb Puanı: {film.Imdb}");
                }
            }

            Console.WriteLine();
        }

    }
}
