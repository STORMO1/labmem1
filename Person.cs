using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labmem1
{
    // Клас для представлення осіб
    internal class Person : interface_pers   // Реалізує інтерфейс для людей
    {
        // Атрибути
        public string Name { get; set; }
        public int Age { get; set; }
        public string Gender { get; set; }
        public string BirthDate { get; set; }
        public bool IsStudent { get; set; }
        public bool IsWorking { get; set; }


        // Конструктор для ініціалізації атрибутів
        public Person(string name, int age, string gender, string birthDate, bool isStudent, bool isWorking)
        {
            Name = name;
            Age = age;
            Gender = gender;
            BirthDate = birthDate;
            IsStudent = isStudent;
            IsWorking = isWorking;
        }


        // Методи, що відображають поведінку особи
        public void Work()
        {
            Console.WriteLine("Людина працює");
        }

        public void Relax()
        {
            Console.WriteLine("Людина відпочиває");
        }

        public void Healing()
        {
            Console.WriteLine("Людина лікується");
        }
    }
}