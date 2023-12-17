using Animal_Registry.Model;

namespace Animal_Registry.Controller
{
    internal class Controller
    {
        private static List<Animal> animals = new List<Animal>();

        public static void Start()
        {
            //Изначально добавленные животные для теста функционала
            animals.Add(new Cat("Kyzya", "11.07.2010"));
            animals.Add(new Dog("Bobik", "23.02.2015"));
            animals.Add(new Cat("Barsik", "07.07.2019"));
            animals.Add(new Donkey("Juh", "15.11.2017"));
            animals.Add(new Horse("Tsar", "31.12.1998"));
            animals.Add(new Camel("SomeCamel", "04.12.2000"));
            animals.Add(new Hamster("Lil", "17.03.2022"));


            bool flag = true;

            while (flag)
            {
                View.View.Menu();

                if (int.TryParse(Console.ReadLine(), out int res))
                {
                    switch (res)
                    {
                        case 1:
                            Console.Clear();
                            AddNewAnimal();
                            Console.WriteLine("\nНажмите любую клавишу для продолжения");
                            Console.ReadLine();
                            break;
                        case 2:
                            Console.Clear();
                            AddNewCommandForAnimal();
                            Console.WriteLine("\nНажмите любую клавишу для продолжения");
                            Console.ReadLine();
                            break;
                        case 3:
                            Console.Clear();
                            View.View.ShowAllAnimals(animals.AsReadOnly());
                            Console.WriteLine("\nНажмите любую клавишу для продолжения");
                            Console.ReadLine();
                            break;
                        case 4:
                            Console.Clear();
                            View.View.ShowCountAnimals(animals.AsReadOnly());
                            Console.WriteLine("\nНажмите любую клавишу для продолжения");
                            Console.ReadLine();
                            break;
                        case 0:
                            flag = false;
                            break;
                        default:
                            Console.WriteLine("Некорректный выбор!");
                            break;
                    }
                }
            }
            
        }

        /// <summary>
        /// Добавление нового животного
        /// </summary>
        private static void AddNewAnimal()
        {
            Console.WriteLine("Животное какого класса хотите добавить?");
            Console.WriteLine("1 - домашние");
            Console.WriteLine("2 - вьючные");
            
            if(int.TryParse(Console.ReadLine(), out int choice))
            {
                if(choice == 1)
                {
                    Console.WriteLine("\nТип животного:");
                    Console.WriteLine("1 - кот");
                    Console.WriteLine("2 - собака");
                    Console.WriteLine("3 - хомяк");
                    if (int.TryParse(Console.ReadLine(), out int animChoice))
                    {
                        switch (animChoice)
                        {
                            case 1:
                                CreateNewAnimal(new Cat());
                                break;
                            case 2:
                                CreateNewAnimal(new Dog());
                                break;
                            case 3:
                                CreateNewAnimal(new Hamster());
                                break;
                            default:
                                Console.WriteLine("Некорректный выбор типа!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод типа!");
                        return;
                    }
                }
                else if(choice == 2)
                {
                    Console.WriteLine("\nТип животного:");
                    Console.WriteLine("1 - лошадь");
                    Console.WriteLine("2 - осел");
                    Console.WriteLine("3 - верблюд");
                    if (int.TryParse(Console.ReadLine(), out int animChoice))
                    {
                        switch (animChoice)
                        {
                            case 1:
                                CreateNewAnimal(new Horse());
                                break;
                            case 2:
                                CreateNewAnimal(new Donkey());
                                break;
                            case 3:
                                CreateNewAnimal(new Camel());
                                break;
                            default:
                                Console.WriteLine("Некорректный выбор типа!");
                                break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Некорректный ввод типа!");
                        return;
                    }
                }
                else
                {
                    Console.WriteLine("Некорректный выбор класса");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Некорректный ввод класса");
                return;
            }
        }

        /// <summary>
        /// Класс саппорт для создания нового животного
        /// </summary>
        /// <param name="animal"></param>
        private static void CreateNewAnimal(Animal animal)
        {
            Console.WriteLine("\nВведите имя:");
            string name = Console.ReadLine();
            Console.WriteLine("Введите дату рождения в формате ДД.ММ.ГГГГ:");
            string birthday = Console.ReadLine();

            if (name != string.Empty || birthday != string.Empty)
            {
                animal.Name = name;
                animal.Birthday = birthday;
                animals.Add(animal);
                Console.WriteLine("Новое животное добавлено!");
            }
        }

        /// <summary>
        /// Добавить существующему животному новые команды
        /// </summary>
        private static void AddNewCommandForAnimal()
        {
            if(animals.Count == 0)
            {
                Console.WriteLine("Список пуст");
            }
            else
            {
                View.View.ShowAllAnimals(animals.AsReadOnly());
                Console.WriteLine("\nВыберите номер животного.");
                if (int.TryParse(Console.ReadLine(), out int numOfAnimal))
                {
                    if (numOfAnimal <= animals.Count && numOfAnimal > 0)
                    {
                        Console.WriteLine("Введите команды через пробел");
                        string[] commands = Console.ReadLine().Split(" ");
                        foreach (string command in commands)
                        {
                            animals[numOfAnimal - 1].AddNewCommand(command);
                        }
                    }
                    else
                    {
                        Console.WriteLine("Животного с таким индексом не существует в списке");
                        return;
                    }
                }
            }
            
        }
    }
}
