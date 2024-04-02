using Labmem1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace Labmem1
{

    class Program
    {// Головний метод Main, який є точкою входу в програму
        static void Main(string[] args)
        {//Щоб "і" відображалась правильно, а не "?".
            Console.OutputEncoding = Encoding.UTF8;
            Console.InputEncoding = Encoding.UTF8;

            Console.WriteLine("Ввести дані кого?");
            Console.WriteLine("1. Собаки");
            Console.WriteLine("2. Людини");

            int choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.Write("Введіть ім'я собаки:");
                string dogName = Console.ReadLine();

                Console.Write("Введіть вік собаки:");
                int dogAge = int.Parse(Console.ReadLine());

                Console.Write("Введіть тип тварини (Домашній улюбленець чи дика тварина?):");
                string dogType = Console.ReadLine();

                Console.Write("Чи має собака дефекти? (Оберіть лиш одну відповідь з цих двох : так/ні):");
                bool dogDefects = Console.ReadLine().Equals("так", StringComparison.OrdinalIgnoreCase);

                Console.Write("Чи навчена собака? (так/ні):");
                bool dogIsTrained = Console.ReadLine().Equals("так", StringComparison.OrdinalIgnoreCase);

                Console.Write("Введіть породу собаки:");
                string dogBreed = Console.ReadLine();


                // Створення об'єкта собаки з введеними користувачем даними
                Animal animal = new Animal(dogName, dogAge, dogType, dogDefects, dogIsTrained, dogBreed);

                Console.WriteLine("Що робить собака?");
                Console.WriteLine("1. Гавкає?");
                Console.WriteLine("2. Виляє хвостом?");
                Console.WriteLine("3. Лікується?");
                int dogActionChoice = int.Parse(Console.ReadLine());

                // Виклик методу відповідно до вибору користувача
                switch (dogActionChoice)
                {
                    case 1:
                        animal.Bark();
                        break;
                    case 2:
                        animal.Activity();
                        break;
                    case 3:
                        animal.Heal();
                        break;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }
            else if (choice == 2)
            {
                Console.Write("Введіть ім'я людини:");
                string name = Console.ReadLine();

                Console.Write("Введіть вік людини:");
                int age = int.Parse(Console.ReadLine());

                Console.Write("Введіть стать людини:");
                string gender = Console.ReadLine();

                Console.Write("Введіть дату народження:");
                string birthDate = Console.ReadLine();

                Console.Write("Чи є людина студентом? (Оберіть лиш одну відповідь з цих двох : так/ні)");
                bool isStudent = Console.ReadLine().Equals("так", StringComparison.OrdinalIgnoreCase); ;

                Console.Write("Чи працює людина? (Оберіть лиш одну відповідь з цих двох : так/ні):");
                bool isWorking = Console.ReadLine().Equals("так", StringComparison.OrdinalIgnoreCase); ;


                // Створення об'єкта людини з введеними користувачем даними
                Person person = new Person(name, age, gender, birthDate, isStudent, isWorking);

                Console.WriteLine("Що робить людина?");
                Console.WriteLine("1. Працює?");
                Console.WriteLine("2. Відпочиває?");
                Console.WriteLine("3. Лікується?");
                int personActionChoice = int.Parse(Console.ReadLine());

                switch (personActionChoice)
                {
                    case 1:
                        person.Work();
                        break;
                    case 2:
                        person.Relax();
                        break;
                    case 3:
                        person.Healing();
                        break;
                    default:
                        Console.WriteLine("Невірний вибір.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Невірний вибір.");
            }
            Console.ReadLine(); //щоб консоль не закривалась
        }
    }
}