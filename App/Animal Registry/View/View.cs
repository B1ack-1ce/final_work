using Animal_Registry.Model;
using System.Collections.ObjectModel;

namespace Animal_Registry.View
{
    internal class View
    {
        public static void Menu()
        {
            Console.Clear();
            Console.WriteLine("1 - Добавить новое животное");
            Console.WriteLine("2 - Добавить новые команды для животного");
            Console.WriteLine("3 - Вывод всех животных");
            Console.WriteLine("4 - Вывод общего и конкретного количества животных");
            Console.WriteLine("0 - выход");
        }

        public static void Commands()
        {
            
        }

        /// <summary>
        /// Вывод всех животных
        /// </summary>
        public static void ShowAllAnimals(ReadOnlyCollection<Animal> animals)
        {
            if (animals.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            else
            {
                for (int i = 0; i < animals.Count; i++)
                {
                    Console.WriteLine($"{i + 1}) {animals[i]}");
                    Console.WriteLine($"Команды: {animals[i].Commands}.\n");
                }
            }
        }

        /// <summary>
        /// Вывод общнего и конкретного количества животных
        /// </summary>
        public static void ShowCountAnimals(ReadOnlyCollection<Animal> animals)
        {
            int packCount = 0;
            int homeCount = 0;
            foreach (Animal animal in animals)
            {
                if (animal.Type == Model.Type.Home)
                    homeCount++;
                else
                    packCount++;
            }
            Console.WriteLine($"Общее количество животных: {Animal.Count}");
            Console.WriteLine($"Вьючных: {packCount} ; Домашних: {homeCount}");
            Console.WriteLine($"Котов: {Cat.CatsCount}");
            Console.WriteLine($"Собак: {Dog.DogsCount}");
            Console.WriteLine($"Хомяков: {Hamster.HamstersCount}");
            Console.WriteLine($"Лошадей:{Horse.HorsesCount}");
            Console.WriteLine($"Ослов: {Donkey.DonkeysCount}");
            Console.WriteLine($"Верблюдов: {Camel.CamelsCount}");
        }
    }
}
