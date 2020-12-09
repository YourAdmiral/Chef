using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Chef.Ingredients;

namespace Chef.Manager
{
    internal class Salad
    {
        public string Name { get; set; }
        private List<Ingredient> _composition = new List<Ingredient>();
        public Salad(string name)
        {
            Name = name;
        }
        public Salad(string name, List<Ingredient> composition)
        {
            Name = name;
            AddIngredients(composition);
        }
        public void AddIngredient(Ingredient vegetable)
        {
            _composition.Add(vegetable);
            vegetable.Handle();
        }
        public void AddIngredients(List<Ingredient> vegetables)
        {
            foreach (var vegetable in vegetables)
                AddIngredient(vegetable);
        }
        public void CountCalories()
        {
            double calories = 0;
            foreach (var item in _composition)
            {
                calories += item.Calories;
            }
            Console.WriteLine($"В данном салате содержится {calories} ккал калорий.");
        }
        public void SortByProteins()
        {
            _composition = _composition.OrderBy(u => u.Proteins).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе белка!");
        }
        public void SortByFats()
        {
            _composition = _composition.OrderBy(u => u.Fats).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе жиров!");
        }
        public void SortByCarbohydrates()
        {
            _composition = _composition.OrderBy(u => u.Carbohydrates).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе углеводов!");
        }
        public void SortByCalories()
        {
            _composition = _composition.OrderBy(u => u.Calories).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе калорий!");
        }
        public void ShowComposition()
        {
            Console.WriteLine($"Состав салата \"{Name}\" включает в себя: ");
            if (_composition.Count != 0)
            {
                foreach (var item in _composition)
                {
                    Console.WriteLine($"{item.GetName()} \"{item.Sort}\" {item.Weight} г.");
                }
            }
            else
            {
                Console.WriteLine("Пусто");
            }
        }
        public void FindCalories()
        {
            if (_composition.Count != 0)
            {
                string choose1 = null;
                string choose2 = null;
                double num1 = 0;
                double num2 = 0;
                Console.WriteLine("Введите минимальное число калорий: ");
                while (choose1 == null)
                {
                    try
                    {
                        choose1 = Console.ReadLine();
                        num1 = Convert.ToDouble(choose1);
                    }
                    catch (Exception)
                    {
                        choose1 = null;
                        Console.WriteLine("Введено неккоректное значение!");
                    }
                }
                Console.WriteLine("Введите максимальное число калорий: ");
                while (choose2 == null)
                {
                    try
                    {
                        choose2 = Console.ReadLine();
                        num2 = Convert.ToDouble(choose2);
                        if (num2 < num1)
                            throw new Exception();
                    }
                    catch (Exception)
                    {
                        choose2 = null;
                        Console.WriteLine("Введено неккоректное значение!");
                    }
                }
                var selectedVegetables = _composition.Where(v => (v.Calories >= num1) && (v.Calories <= num2));
                if (selectedVegetables.Count() != 0)
                {
                    Console.WriteLine($"Ингредиенты соответствующие заданному диапазону калорийности ({num1} - {num2}): ");
                    foreach (Ingredient item in selectedVegetables)
                    {
                        Console.WriteLine($"{item.GetName()} \"{item.Sort}\" {item.Calories} ккал.");
                    }
                }
                else
                {
                    Console.WriteLine("Совпадений не найдено!");
                }
            }
            else
            {
                Console.WriteLine("В салате отсутствуют ингредиенты!");
            }
        }
    }
}
