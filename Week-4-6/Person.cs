using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_6
{
    public abstract class Person
    {
        protected Person(string fullName, string? department)
        {
            FullName = fullName;
            Department = department ?? "bilinmiyor"; // eğer departman null olabilir dersem ekstra kontrol etmem gerekir veya default bir tanımlama
        }

        public string FullName { get; set; }
        public string? Department { get; set; } // burada değişkenimin null olabileceğini belirtiyorum.

        public abstract void Pozition();

        public void WriteToConsole()
        {
            Console.Write($"{FullName} adlı kişinin çalıştığı departman {Department} ");
            Pozition();
        }
    }

    public class Employee : Person
    {
        readonly string _pozisyon;
        public Employee(string fullName, string? department, string pozisyon) : base(fullName, department) // base kullanıyorum çünkü personum yapıcı bir sınıf bu yüzden constructorunu almam lazım
                                                                                                           // yoksa parametrelerin değerlerini alamam

        {
            _pozisyon = pozisyon;
        }

        public override void Pozition()
        {
            Console.WriteLine($"{_pozisyon} olarak çalışıyor.");
        }
    }

}
