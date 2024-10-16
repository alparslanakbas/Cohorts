using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_4.Models
{
    public class Person
    {
        public required string Name { get; set; }
        public required string Surname { get; set; }
        public DateTime BirthDate { get; set; }

        public virtual string GetInfo()
        {
            return
                $"Name: {Name} \n"
                +
                $"Surname: {Surname} \n"
                +
                $"BirthDate: {BirthDate.ToShortDateString()} \n"
                ;
        }
    }

    public class Student : Person
    {
        public bool IsStudent { get; set; }

        public override string GetInfo() 
        {
            return base.GetInfo() + $"IsStudent: {IsStudent}";
        }
    }

    public class Teacher : Person
    {
        public bool IsTeacher { get; set; }

        public override string GetInfo()
        {
            return base.GetInfo() + $"Is Teacher: {IsTeacher}";
        }
    }

}
