using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4_4
{
    public class BasePerson
    {
        public Guid Id { get; set; }
        public string FirstName { get; set; } = string.Empty!;
        public string Surname { get; set; } = string.Empty!;
    }


    public class Student : BasePerson
    {
        public Guid StudentIdentifyNumber { get; set; }

        public void WriteToConsoleForStudent()
        {
            Console.WriteLine($"{Id} Id'ye sahip Öğrencinin Adı: {FirstName} Soyadı: {Surname} Okul Numarası:{StudentIdentifyNumber}");
        }
    }


    public class Teacher : BasePerson
    {
        public float Salary { get; set; }

        public void WriteToConsoleForTeacher()
        {
            Console.WriteLine($"{Id} Id'ye sahip Öğretmenin Adı: {FirstName} Soyadı: {Surname} Maaş Bilgisi:{Salary}");
        }
    }


    

    

}
