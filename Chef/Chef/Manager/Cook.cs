using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Chef.Cultivators.FetusCultivators;
using Chef.Cultivators.OnionCultivators;
using Chef.Cultivators.SpiceCultivators;
using Chef.Cultivators.LeafCultivators;
using Chef.Cultivators.GreenCultivators;
using Chef.Cultivators.RootCultivators;
using Chef.Ingredients;
using Chef.Manager;

namespace Chef
{
    internal class Cook
    {
        private static List<Ingredient> _ingredients = new List<Ingredient>();
        private static List<Salad> _salads = new List<Salad>();
        private static RootCultivator _rootCultivator;
        private static FetusCultivator _fetusCultivator;
        private static OnionCultivator _onionCultivator;
        private static GreenCultivator _greenCultivator;
        private static LeafCultivator _leafCultivator;
        private static SpiceCultivator _spiceCultivator;
        private static void Main(string[] args)
        {
            Choose();
        }
        private static void Choose()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите действие:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Добавить ингредиенты на склад\n" +
                "2 - Приготовить салат\n" +
                "3 - Проверить склад ингредиентов\n" +
                "4 - Проверить список салатов\n" +
                "0 - Выйти");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        CreateIngredient();
                        break;
                    case ConsoleKey.D2:
                        CreateSalad();
                        break;
                    case ConsoleKey.D3:
                        CheckStorage();
                        break;
                    case ConsoleKey.D4:
                        CheckSalads();
                        break;
                    case ConsoleKey.D0:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void CreateIngredient()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите тип ингредиента:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Овощ\n" +
                "2 - Специя\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        ChooseVegetable();
                        break;
                    case ConsoleKey.D2:
                        ChooseSpice();
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void ChooseVegetable()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите тип овоща:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Корнеплод\n" +
                "2 - Плод\n" +
                "3 - Зелень\n" +
                "4 - Лук\n" +
                "5 - Листовое\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        ChooseRoot();
                        break;
                    case ConsoleKey.D2:
                        ChooseFetus();
                        break;
                    case ConsoleKey.D3:
                        ChooseGreen();
                        break;
                    case ConsoleKey.D4:
                        ChooseOnion();
                        break;
                    case ConsoleKey.D5:
                        ChooseLeaf();
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void CreateSalad()
        {
            if (_ingredients.Count != 0)
            {
                Console.WriteLine("Выберите название для салата: ");
                string name = Console.ReadLine();
                List<Ingredient> composition = new List<Ingredient>();
                string choose = null;
                int num;
                while (choose != "0")
                {
                    Console.WriteLine("Выберите что добавить в салат:");
                    for (int i = 0; i < _ingredients.Count; i++)
                        Console.WriteLine(i + 1 + " - " + _ingredients[i].GetName() + " \"" + _ingredients[i].Sort + "\"");
                    Console.WriteLine("0 - Приготовить");
                    try
                    {
                        choose = Console.ReadLine();
                        num = Convert.ToInt32(choose) - 1;
                        if (choose != "0")
                        {
                            Console.WriteLine($"В салат был добавлен: {_ingredients[num].GetName()} \"{_ingredients[num].Sort}\"");
                            composition.Add(_ingredients[num]);
                            _ingredients.RemoveAt(num);
                        }
                        else
                        {
                            if (composition.Count != 0)
                            {
                                _salads.Add(new Salad(name, composition));
                                Console.WriteLine($"Салат \"{name}\" готов!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Для начала добавьте что-нибудь в салат!");
                                choose = null;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введено неккоректное значение!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Требуются ингредиенты!");
            }
        }
        private static void CheckStorage()
        {
            if (_ingredients.Count != 0)
            {
                string choose = null;
                int num;
                Console.WriteLine("Ингредиенты имеющиеся на складе: ");
                for (int i = 0; i < _ingredients.Count; i++)
                    Console.WriteLine($"{i + 1} - {_ingredients[i].GetName()} \"{_ingredients[i].Sort}\" {_ingredients[i].Weight} г.");
                Console.WriteLine("0 - Вернуться");
                while (choose != "0")
                {
                    try
                    {
                        choose = Console.ReadLine();
                        num = Convert.ToInt32(choose) - 1;
                        if (choose != "0")
                            _ingredients[num].ShowInformation();
                        else
                            break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введено неккоректное значение!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Склад пуст!");
            }
        }
        private static void CheckSalads()
        {
            if (_salads.Count != 0)
            {
                string choose = null;
                int num;
                while (choose != "0")
                {
                    Console.WriteLine("Салаты имеющиеся в меню: ");
                    for (int i = 0; i < _salads.Count; i++)
                        Console.WriteLine($"{i + 1} - {_salads[i].Name}");
                    Console.WriteLine("0 - Вернуться");
                    try
                    {
                        choose = Console.ReadLine();
                        num = Convert.ToInt32(choose) - 1;
                        if (choose != "0")
                            SaladAction(num);
                        else
                            break;
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Введено неккоректное значение!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Салаты отсутствуют!");
            }
        }
        private static void SaladAction(int num)
        {
            _salads[num].ShowComposition();
            _salads[num].CountCalories();
            string choose = null;
            while (choose != "0")
            {
                Console.WriteLine($"Выберите действие над салатом \"{_salads[num].Name}\":");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Сортировать состав салата по калориям\n" +
                "2 - Сортировать состав салата по жирам\n" +
                "3 - Сортировать состав салата по углеводам\n" +
                "4 - Сортировать состав салата по белкам\n" +
                "5 - Найти ингредиенты в салате соответствующие заданному диапазону калорийности\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        _salads[num].SortByCalories();
                        break;
                    case "2":
                        _salads[num].SortByFats();
                        break;
                    case "3":
                        _salads[num].SortByCarbohydrates();
                        break;
                    case "4":
                        _salads[num].SortByProteins();
                        break;
                    case "5":
                        _salads[num].FindCalories();
                        break;
                    case "0":
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void ChooseRoot()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите нужный корнеплод:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Картофель\n" +
                "2 - Морковь\n" +
                "3 - Свекла\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        _rootCultivator = new PotatoCultivator();
                        _ingredients.Add(_rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D2:
                        _rootCultivator = new CarrotCultivator();
                        _ingredients.Add(_rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D3:
                        _rootCultivator = new BeetCultivator();
                        _ingredients.Add(_rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void ChooseFetus()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите нужный плод:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Томат\n" +
                "2 - Перец\n" +
                "3 - Огурец\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        _fetusCultivator = new TomatoCultivator();
                        _ingredients.Add(_fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D2:
                        _fetusCultivator = new PepperCultivator();
                        _ingredients.Add(_fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D3:
                        _fetusCultivator = new CucumberCultivator();
                        _ingredients.Add(_fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void ChooseOnion()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите нужный лук:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Чеснок\n" +
                "2 - Лук-порей\n" +
                "3 - Лук репчатый\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        _onionCultivator = new GarlicCultivator();
                        _ingredients.Add(_onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D2:
                        _onionCultivator = new LeekOnionCultivator();
                        _ingredients.Add(_onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D3:
                        _onionCultivator = new NapiformOnionCultivator();
                        _ingredients.Add(_onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void ChooseGreen()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите нужную зелень:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Щавель\n" +
                "2 - Петрушка\n" +
                "3 - Укроп\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        _greenCultivator = new SorrelCultivator();
                        _ingredients.Add(_greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D2:
                        _greenCultivator = new ParsleyCultivator();
                        _ingredients.Add(_greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D3:
                        _greenCultivator = new DillCultivator();
                        _ingredients.Add(_greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void ChooseLeaf()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите нужное листовое:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Белокочанная капуста\n" +
                "2 - Брокколи\n" +
                "3 - Кольраби\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        _leafCultivator = new WhiteCabbageCultivator();
                        _ingredients.Add(_leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D2:
                        _leafCultivator = new BroccoliCultivator();
                        _ingredients.Add(_leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D3:
                        _leafCultivator = new KohlrabiCultivator();
                        _ingredients.Add(_leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
        private static void ChooseSpice()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Выберите нужную специю:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Соль\n" +
                "2 - Сахар\n" +
                "3 - Уксус\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        _spiceCultivator = new SaltCultivator();
                        _ingredients.Add(_spiceCultivator.CultivateSpice());
                        break;
                    case ConsoleKey.D2:
                        _spiceCultivator = new SugarCultivator();
                        _ingredients.Add(_spiceCultivator.CultivateSpice());
                        break;
                    case ConsoleKey.D3:
                        _spiceCultivator = new VinegarCultivator();
                        _ingredients.Add(_spiceCultivator.CultivateSpice());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("Вы выбрали неподходящее значение!");
                        break;
                }
            }
        }
    }
}
