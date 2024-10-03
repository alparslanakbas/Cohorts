using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_2
{
    public class HelperFunctions
    {
        public void SongLyrics() 
        {
            Console.WriteLine("bir yıldız gibi kayarım hayatından, yapacağın tek şey dilek tutmak olur benim arkamdan");
        }

        public long RandomGenerateNumber()
        {
            var random = new Random();
            long GeneratedNumber = random.Next(100) * 2; // kalanın sıfır olması için random çift sayı üretmek gerek bunun için 100 e kadar üretilen her sayıyı 2 ile çarpmam gerekiyr.

            Console.WriteLine($"Üretilen sayı: {GeneratedNumber}");
            return GeneratedNumber % 2;
        }

        public long Calculator(long number1, long number2)
        {
            var result = number1 * number2;
            return result;
        }

        public void WelcomeMr(string name, string surname)
        {
            Console.WriteLine($"Hoşgeldiniz {name} {surname}");
        }
    }
}
