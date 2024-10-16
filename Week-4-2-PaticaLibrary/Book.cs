using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_2_PaticaLibrary
{
    public class Book
    {
        // Properties for book info
        public string? Name { get; set; }
        public string? WriterName { get; set; }
        public string? WriterSurname { get; set; }
        public int PageNumber { get; set; }
        public string? Publisher { get; set; }
        public DateTime RegisterDate { get; set; }



        // default ctor not any value
        public Book()
        {
            Name = "Adı Aylin";
            WriterName = "Ayşe";
            WriterSurname = "Kulin";
            PageNumber = 398;
            Publisher = "Remzi Kitap Evi";
            RegisterDate = DateTime.UtcNow;
        }


        // 4 value ctor
        public Book(string name, string? writerName, int pageNumber, string? publisher)
        {
            Name = name;
            WriterName = writerName;
            PageNumber = pageNumber;
            Publisher = publisher;
            RegisterDate = DateTime.UtcNow;
        }

        // frunction for print of console
        public void SaveBook()
        {
            Console.WriteLine
                (
                    $"Name: {Name} \n"
                    +
                    $"Writer Name: {WriterName} \n"
                    +
                    $"Writer Surname: {WriterSurname} \n"
                    +
                    $"Page Number: {PageNumber} \n"
                    +
                    $"Publisher: {Publisher} \n"
                    +
                    $"Register Date: {RegisterDate.ToShortDateString()} \n"
                );
        }

        



    }
}
