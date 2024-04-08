using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9aprel2
{
    internal class Student
    {
        static int Count=0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }




        public Student(string name, string surname)
        {
            Name = name;
            Surname = surname;
            Id = Count++ ;
        }

        public void GetInfo()
        {
            Console.WriteLine($"ID: {Id}, Name: {Name}, Surname: {Surname}");
        }


    }
}
