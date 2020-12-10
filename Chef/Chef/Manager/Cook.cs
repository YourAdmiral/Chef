using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using Chef.Cultivators;
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
        private static IList<Ingredient> _ingredients = new List<Ingredient>();
        private static IList<Salad> _salads = new List<Salad>();
        private static RootCultivator _rootCultivator;
        private static FetusCultivator _fetusCultivator;
        private static OnionCultivator _onionCultivator;
        private static GreenCultivator _greenCultivator;
        private static LeafCultivator _leafCultivator;
        private static SpiceCultivator _spiceCultivator;
        private static PotatoCultivator _potatoCultivator;
        private static CarrotCultivator _carrotCultivator;
        private static BeetCultivator _beetCultivator;
        private static TomatoCultivator _tomatoCultivator;
        private static CucumberCultivator _cucumberCultivator;
        private static PepperCultivator _pepperCultivator;
        private static DillCultivator _dillCultivator;
        private static ParsleyCultivator _parsleyCultivator;
        private static SorrelCultivator _sorrelCultivator;
        private static BroccoliCultivator _broccoliCultivator;
        private static KohlrabiCultivator _kohlrabiCultivator;
        private static WhiteCabbageCultivator _whiteCabbageCultivator;
        private static GarlicCultivator _garlicCultivator;
        private static LeekOnionCultivator _leekOnionCultivator;
        private static NapiformOnionCultivator _napiformOnionCultivator;

        private static void Main(string[] args)
        {
            Choose();
        }
        private static void Choose()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Choose one of the actions:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Add ingredients to storage\n" +
                "2 - Prepare salad\n" +
                "3 - Check ingredients storage\n" +
                "4 - Check list of salads\n" +
                "0 - Exit");
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
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void CreateIngredient()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select the type of ingredient:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Vegetable\n" +
                "2 - Spice\n" +
                "0 - Return");
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
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void ChooseVegetable()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select the type of vegetable:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Root\n" +
                "2 - Fetus\n" +
                "3 - Green\n" +
                "4 - Onion\n" +
                "5 - Leaf\n" +
                "0 - Return");
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
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void CreateSalad()
        {
            if (_ingredients.Count != 0)
            {
                Console.WriteLine("Choose a name for the salad:");
                string name = Console.ReadLine();
                List<Ingredient> composition = new List<Ingredient>();
                string choose = null;
                int num;
                while (choose != "0")
                {
                    Console.WriteLine("Choose what to add to the salad:");
                    for (int i = 0; i < _ingredients.Count; i++)
                        Console.WriteLine(i + 1 + " - " + _ingredients[i].GetName() + " \"" + _ingredients[i].Sort + "\"");
                    Console.WriteLine("0 - Cook");
                    try
                    {
                        choose = Console.ReadLine();
                        num = Convert.ToInt32(choose) - 1;
                        if (choose != "0")
                        {
                            Console.WriteLine($"Added to the salad: {_ingredients[num].GetName()} \"{_ingredients[num].Sort}\"");
                            composition.Add(_ingredients[num]);
                            _ingredients.RemoveAt(num);
                        }
                        else
                        {
                            if (composition.Count != 0)
                            {
                                _salads.Add(new Salad(name, composition));
                                Console.WriteLine($"Salad \"{name}\" ready!");
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Add something to your salad first!");
                                choose = null;
                            }
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("Incorrect value entered!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Ingredients required!");
            }
        }
        private static void CheckStorage()
        {
            if (_ingredients.Count != 0)
            {
                string choose = null;
                int num;
                Console.WriteLine("Storage ingredients:");
                for (int i = 0; i < _ingredients.Count; i++)
                    Console.WriteLine($"{i + 1} - {_ingredients[i].GetName()} \"{_ingredients[i].Sort}\" {_ingredients[i].Weight} г.");
                Console.WriteLine("0 - Return");
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
                        Console.WriteLine("Incorrect value entered!");
                    }
                }
            }
            else
            {
                Console.WriteLine("Storage is empty!");
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
                    Console.WriteLine("Salads available on the menu:");
                    for (int i = 0; i < _salads.Count; i++)
                        Console.WriteLine($"{i + 1} - {_salads[i].Name}");
                    Console.WriteLine("0 - Return");
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
                        Console.WriteLine("Incorrect value entered!");
                    }
                }
            }
            else
            {
                Console.WriteLine("There are no salads!");
            }
        }
        private static void SaladAction(int num)
        {
            _salads[num].ShowComposition();
            _salads[num].CountCalories();
            string choose = null;
            while (choose != "0")
            {
                Console.WriteLine($"Choose an action on the salad \"{_salads[num].Name}\":");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Sort composition of the salad by calories\n" +
                "2 - Sort composition of the salad by fat\n" +
                "3 - Sort composition of the salad by carbohydrates\n" +
                "4 - Sort composition of the salad by proteins\n" +
                "5 - Find ingredients in a salad that match a given calorie range\n" +
                "0 - Return");
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
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void ChooseRoot()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select desired root vegetable:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Potato\n" +
                "2 - Carrot\n" +
                "3 - Beet\n" +
                "0 - Return");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        if (_potatoCultivator==null)
                            _potatoCultivator = new PotatoCultivator();
                        _rootCultivator = _potatoCultivator;
                        _ingredients.Add(_rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D2:
                        if (_carrotCultivator == null)
                            _carrotCultivator = new CarrotCultivator();
                        _rootCultivator = _carrotCultivator;
                        _ingredients.Add(_rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D3:
                        if (_beetCultivator == null)
                            _beetCultivator = new BeetCultivator();
                        _rootCultivator = _beetCultivator;
                        _ingredients.Add(_rootCultivator.CultivateRoot());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void ChooseFetus()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select desired fetus vegetable:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Tomato\n" +
                "2 - Pepper\n" +
                "3 - Cucumber\n" +
                "0 - Return");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        if (_tomatoCultivator == null)
                            _tomatoCultivator = new TomatoCultivator();
                        _fetusCultivator = _tomatoCultivator;
                        _ingredients.Add(_fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D2:
                        if (_pepperCultivator == null)
                            _pepperCultivator = new PepperCultivator();
                        _fetusCultivator = _pepperCultivator;
                        _ingredients.Add(_fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D3:
                        if (_cucumberCultivator == null)
                            _cucumberCultivator = new CucumberCultivator();
                        _fetusCultivator = _cucumberCultivator;
                        _ingredients.Add(_fetusCultivator.CultivateFetus());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void ChooseOnion()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select desired onion vegetable:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Garlic\n" +
                "2 - Leek onion\n" +
                "3 - Napiform onion\n" +
                "0 - Return");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        if (_garlicCultivator == null)
                            _garlicCultivator = new GarlicCultivator();
                        _onionCultivator = _garlicCultivator;
                        _ingredients.Add(_onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D2:
                        if (_leekOnionCultivator == null)
                            _leekOnionCultivator = new LeekOnionCultivator();
                        _onionCultivator = _leekOnionCultivator;
                        _ingredients.Add(_onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D3:
                        if (_napiformOnionCultivator == null)
                            _napiformOnionCultivator = new NapiformOnionCultivator();
                        _onionCultivator = _napiformOnionCultivator;
                        _ingredients.Add(_onionCultivator.CultivateOnion());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void ChooseGreen()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select desired green vegetable:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Sorrel\n" +
                "2 - Parsley\n" +
                "3 - Dill\n" +
                "0 - Return");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        if (_sorrelCultivator == null)
                            _sorrelCultivator = new SorrelCultivator();
                        _greenCultivator = _sorrelCultivator;
                        _ingredients.Add(_greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D2:
                        if (_parsleyCultivator == null)
                            _parsleyCultivator = new ParsleyCultivator();
                        _greenCultivator = _parsleyCultivator;
                        _ingredients.Add(_greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D3:
                        if (_dillCultivator == null)
                            _dillCultivator = new DillCultivator();
                        _greenCultivator = _dillCultivator;
                        _ingredients.Add(_greenCultivator.CultivateGreen());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void ChooseLeaf()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select desired leaf vegetable:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - White cabbage\n" +
                "2 - Broccoli\n" +
                "3 - Kohlrabi\n" +
                "0 - Return");
                Console.WriteLine("-----------------------------");
                choose = Console.ReadKey(true).Key;
                switch (choose)
                {
                    case ConsoleKey.D1:
                        if (_whiteCabbageCultivator == null)
                            _whiteCabbageCultivator = new WhiteCabbageCultivator();
                        _leafCultivator = _whiteCabbageCultivator;
                        _ingredients.Add(_leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D2:
                        if (_broccoliCultivator == null)
                            _broccoliCultivator = new BroccoliCultivator();
                        _leafCultivator = _broccoliCultivator;
                        _ingredients.Add(_leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D3:
                        if (_kohlrabiCultivator == null)
                            _kohlrabiCultivator = new KohlrabiCultivator();
                        _leafCultivator = _kohlrabiCultivator;
                        _ingredients.Add(_leafCultivator.CultivateLeaf());
                        break;
                    case ConsoleKey.D0:
                        break;
                    default:
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
        private static void ChooseSpice()
        {
            ConsoleKey choose = default;
            while (choose != ConsoleKey.D0)
            {
                Console.WriteLine("Select desired spice:");
                Console.WriteLine("-----------------------------");
                Console.WriteLine(
                "1 - Salt\n" +
                "2 - Sugar\n" +
                "3 - Vinegar\n" +
                "0 - Return");
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
                        Console.WriteLine("You have chosen the wrong value!");
                        break;
                }
            }
        }
    }
}
