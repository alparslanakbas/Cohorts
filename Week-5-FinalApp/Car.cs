using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_5_FinalApp
{
    public class Car
    {
        public Car(string marka, string model, string color, int doorCount)
        {
            Marka = marka;
            Model = model;
            Color = color;
            DoorCount = doorCount;
        }

        public string Marka { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }
        public int DoorCount { get; set; }
        public Guid SerialNumber { get; private set; } = Guid.NewGuid();
        public DateTime CreatedDate { get; private set; } = DateTime.Now;

    }
}
