using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_3
{
    public class Car
    {
        // string ifadelerinizin nullable uyarı vermesi sizin kontrol etmenizi söyler, 
        // string? şeklinde ifade ederseniz değişkenin boş da olabileceğini ifade edersiniz. 
        // required derseniz değişkeniniz değer almak zorunda demiş olursunuz.


        public required string Mark { get; set; } // = string.Empty; veya string.empty!; şeklinde de kullanabilirsiniz.
        public required string Model { get; set; }
        public string? Color { get; set; }
        private int _doorCount { get; set; }

        public int DoorCount
        {
            get { return _doorCount; }
            set
            {
                if (value == 2 || value == 4)
                {
                    _doorCount = value;
                }

                else
                {
                    _doorCount = -1;
                    Console.WriteLine("Hata.! Kapı sayısı 2 veya 4 olabilir.!");
                }
            }
        }

        public void GetInfo()
        {
            Console.WriteLine
                (
                    $"Marka: {Mark} \n"
                    +
                    $"Model: {Model} \n"
                    +
                    $"Color: {Color} \n"
                    +
                    $"Door Count: {DoorCount}"
                );
        }
    }
}
