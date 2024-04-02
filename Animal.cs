using Labmem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Labmem1
{    // Клас для представлення тварин
    internal class Animal : interface_anim // Реалізує інтерфейс для тварин

    {   // Атрибути тварини
        public string Name { get; set; }
        public int Age { get; set; }
        public string TypeOfAnimal { get; set; }
        public bool Deffects { get; set; }
        public bool IsTrained { get; set; }
        public string Breed { get; set; }


        // Конструктор для ініціалізації атрибутів
        public Animal(string dogName, int dogAge, string dogType, bool dogDefects, bool isTrained, string dogBreed)
        {
            Name = dogName;
            Age = dogAge;
            TypeOfAnimal = dogType;
            Deffects = dogDefects;
            IsTrained = isTrained;
            Breed = dogBreed;
        }



        // Методи, що відображають поведінку тварини
        public void Activity()
        {
            Console.WriteLine("Пес виляє хвостом");
        }

        public void Heal()
        {
            Console.WriteLine("Собака лікується у ветеринара");
        }

        public void Bark()
        {
            Console.WriteLine("Собака гавкає");
        }
    }
}