file class Author
{
    public int Id { get; set; }
    public required string Name { get; set; }
}

file class Book
{
    public int Id { get; set; }
    public required string Title { get; set; }
    public int AuthorId { get; set; }
}


class Program
{
    static void Main()
    {
        IReadOnlyList<Author> authors = new List<Author>
        {
            new Author { Id = 1, Name = "George R. R. Martin" },
            new Author { Id = 2, Name = "J. R. R. Tolkien" },
            new Author { Id = 3, Name = "J. K. Rowling" }
        };

        IReadOnlyList<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "A Game of Thrones", AuthorId = 1 },
            new Book { Id = 2, Title = "A Clash of Kings", AuthorId = 1 },
            new Book { Id = 3, Title = "A Storm of Swords", AuthorId = 1 },
            new Book { Id = 4, Title = "The Hobbit", AuthorId = 2 },
            new Book { Id = 5, Title = "The Lord of the Rings", AuthorId = 2 },
            new Book { Id = 6, Title = "Harry Potter and the Philosopher's Stone", AuthorId = 3 },
            new Book { Id = 7, Title = "Harry Potter and the Chamber of Secrets", AuthorId = 3 },
            new Book { Id = 8, Title = "Harry Potter and the Prisoner of Azkaban", AuthorId = 3 }
        };

        var joinResult = books.Join(authors,
                                    book => book.AuthorId,
                                    author => author.Id,
                                    (book, author) => new
                                    {
                                        BookTitle = book.Title,
                                        AuthorName = author.Name
                                    });

        foreach (var item in joinResult)
        {
            Console.WriteLine($"Kitap: {item.BookTitle}, Yazar: {item.AuthorName}");
        }
        
    }
}