using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_1
{
    public class Baby
    {
        public Baby()
        {
            Name = "Kayıp bebek";
            Surname = "Bilinmiyor";
            BirthDate = DateTime.UtcNow;
        }

        public Baby(string name, string surname)
        {
            Name = name;
            Surname = surname;
            BirthDate = DateTime.UtcNow;
            Console.WriteLine("Ingaaaaa");
        }

        public void GetInfo()
        {
            Console.WriteLine
                (
                $"Name: {Name} \n"
                +
                $"Surname: {Surname} \n"
                +
                $"Birth Date: {BirthDate.ToLongDateString()}"               
                ); 
                
        }

        public string Name { get; set; }
        public string Surname { get; set; }
        public DateTime BirthDate { get; set; }
    }
}
