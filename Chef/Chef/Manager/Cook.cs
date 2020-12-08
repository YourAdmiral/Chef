using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace Chef
{
    internal class Cook
    {
        private static List<Vegetables.Vegetable> vegetablesStorage = new List<Vegetables.Vegetable>();
        private static List<Manager.Salad> salads = new List<Manager.Salad>();
        private static Cultivators.RootCultivators.RootCultivator rootCultivator;
        private static Cultivators.FetusCultivators.FetusCultivator fetusCultivator;
        private static Cultivators.OnionCultivators.OnionCultivator onionCultivator;
        private static Cultivators.GreenCultivators.GreenCultivator greenCultivator;
        private static Cultivators.LeafCultivators.LeafCultivator leafCultivator;
        private static Cultivators.SpiceCultivators.SpiceCultivator spiceCultivator;
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
                "3 - Проверить склад овощей\n" +
                "4 - Проверить список салатов\n" +
                "0 - Выйти");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        CreateVegetable();
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
        private static void CreateVegetable()
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
                "6 - Специя\n" +
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
                    case ConsoleKey.D6:
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
        private static void CreateSalad()
        {
            if (vegetablesStorage.Count != 0)
            {
                Console.WriteLine("Выберите название для салата: ");
                string name = Console.ReadLine();
                List<Vegetables.Vegetable> composition = new List<Vegetables.Vegetable>();
                string choose = null;
                int num;
                while (choose != "0")
                {
                    Console.WriteLine("Выберите что добавить в салат:");
                    for (int i = 0; i < vegetablesStorage.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " - " + vegetablesStorage[i].GetVegetableName() + " \"" + vegetablesStorage[i].Sort + "\"");
                    }
                    Console.WriteLine("0 - Приготовить");
                    try
                    {
                        choose = Console.ReadLine();
                        num = Convert.ToInt32(choose) - 1;
                        if (choose != "0")
                        {
                            Console.WriteLine("В салат был добавлен: " +
                            vegetablesStorage[num].GetVegetableName() +
                            " \"" + vegetablesStorage[num].Sort + "\"");
                            composition.Add(vegetablesStorage[num]);
                            vegetablesStorage.RemoveAt(num);
                        }
                        else
                        {
                            if (composition.Count != 0)
                            {
                                salads.Add(new Manager.Salad(name, composition));
                                Console.WriteLine("Салат \"" + name + "\" готов!");
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
            if (vegetablesStorage.Count != 0)
            {
                string choose = null;
                int num;
                Console.WriteLine("Ингредиенты имеющиеся на складе: ");
                for (int i = 0; i < vegetablesStorage.Count; i++)
                {
                    Console.WriteLine(i + 1 + " - " + vegetablesStorage[i].GetVegetableName() + " \"" +
                        vegetablesStorage[i].Sort + "\" " +
                        vegetablesStorage[i].Weight + " г.");
                }
                Console.WriteLine("0 - Вернуться");
                while (choose != "0")
                {
                    try
                    {
                        choose = Console.ReadLine();
                        num = Convert.ToInt32(choose) - 1;
                        if (choose != "0")
                        {
                            vegetablesStorage[num].GetInformation();
                        }
                        else
                        {
                            break;
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
                Console.WriteLine("Склад пуст!");
            }
        }
        private static void CheckSalads()
        {
            if (salads.Count != 0)
            {
                string choose = null;
                int num;
                while (choose != "0")
                {
                    Console.WriteLine("Салаты имеющиеся в меню: ");
                    for (int i = 0; i < salads.Count; i++)
                    {
                        Console.WriteLine(i + 1 + " - " + salads[i].Name);
                    }
                    Console.WriteLine("0 - Вернуться");
                    try
                    {
                        choose = Console.ReadLine();
                        num = Convert.ToInt32(choose) - 1;
                        if (choose != "0")
                        {
                            SaladAction(num);
                        }
                        else
                        {
                            break;
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
                Console.WriteLine("Салаты отсутствуют!");
            }
        }
        private static void SaladAction(int num)
        {
            salads[num].ShowComposition();
            salads[num].CountCalories();
            string choose = null;
            while (choose != "0")
            {
                Console.WriteLine("Выберите действие над салатом \"" + salads[num].Name + "\":");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Сортировать состав салата по калориям\n" +
                "2 - Сортировать состав салата по жирам\n" +
                "3 - Сортировать состав салата по углеводам\n" +
                "4 - Сортировать состав салата по белкам\n" +
                "5 - Найти ингридиенты в салате соответствующие заданному диапазону калорийности\n" +
                "0 - Вернуться");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadLine();
                switch (choose)
                {
                    case "1":
                        salads[num].SortByCalories();
                        break;
                    case "2":
                        salads[num].SortByFats();
                        break;
                    case "3":
                        salads[num].SortByCarbohydrates();
                        break;
                    case "4":
                        salads[num].SortByProteins();
                        break;
                    case "5":
                        salads[num].FindCalories();
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
                        rootCultivator = new Cultivators.RootCultivators.PotatoCultivator();
                        vegetablesStorage.Add(rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D2:
                        rootCultivator = new Cultivators.RootCultivators.CarrotCultivator();
                        vegetablesStorage.Add(rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D3:
                        rootCultivator = new Cultivators.RootCultivators.BeetCultivator();
                        vegetablesStorage.Add(rootCultivator.CultivateRoot());
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
                        fetusCultivator = new Cultivators.FetusCultivators.TomatoCultivator();
                        vegetablesStorage.Add(fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D2:
                        fetusCultivator = new Cultivators.FetusCultivators.PepperCultivator();
                        vegetablesStorage.Add(fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D3:
                        fetusCultivator = new Cultivators.FetusCultivators.CucumberCultivator();
                        vegetablesStorage.Add(fetusCultivator.CultivateFetus());
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
                        onionCultivator = new Cultivators.OnionCultivators.GarlicCultivator();
                        vegetablesStorage.Add(onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D2:
                        onionCultivator = new Cultivators.OnionCultivators.LeekOnionCultivator();
                        vegetablesStorage.Add(onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D3:
                        onionCultivator = new Cultivators.OnionCultivators.NapiformOnionCultivator();
                        vegetablesStorage.Add(onionCultivator.CultivateOnion());
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
                        greenCultivator = new Cultivators.GreenCultivators.SorrelCultivator();
                        vegetablesStorage.Add(greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D2:
                        greenCultivator = new Cultivators.GreenCultivators.ParsleyCultivator();
                        vegetablesStorage.Add(greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D3:
                        greenCultivator = new Cultivators.GreenCultivators.DillCultivator();
                        vegetablesStorage.Add(greenCultivator.CultivateGreen());
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
                        leafCultivator = new Cultivators.LeafCultivators.WhiteCabbageCultivator();
                        vegetablesStorage.Add(leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D2:
                        leafCultivator = new Cultivators.LeafCultivators.BroccoliCultivator();
                        vegetablesStorage.Add(leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D3:
                        leafCultivator = new Cultivators.LeafCultivators.KohlrabiCultivator();
                        vegetablesStorage.Add(leafCultivator.CultivateLeaf());
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
                        spiceCultivator = new Cultivators.SpiceCultivators.SaltCultivator();
                        vegetablesStorage.Add(spiceCultivator.CultivateSpice());
                        break;
                    case ConsoleKey.D2:
                        spiceCultivator = new Cultivators.SpiceCultivators.SugarCultivator();
                        vegetablesStorage.Add(spiceCultivator.CultivateSpice());
                        break;
                    case ConsoleKey.D3:
                        spiceCultivator = new Cultivators.SpiceCultivators.VinegarCultivator();
                        vegetablesStorage.Add(spiceCultivator.CultivateSpice());
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
