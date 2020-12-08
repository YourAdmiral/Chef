using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chef.Manager
{
    internal class Salad
    {
        public string Name { get; set; }
        private List<Vegetables.Vegetable> composition = new List<Vegetables.Vegetable>();
        public Salad(string name)
        {
            Name = name;
        }
        public Salad(string name, List<Vegetables.Vegetable> composition)
        {
            Name = name;
            AddVegetables(composition);
        }
        public void AddVegetable(Vegetables.Vegetable vegetable)
        {
            composition.Add(vegetable);
            vegetable.Handle();
        }
        public void AddVegetables(List<Vegetables.Vegetable> vegetables)
        {
            foreach (var vegetable in vegetables)
                AddVegetable(vegetable);
        }
        public void CountCalories()
        {
            double calories = 0;
            foreach (var item in composition)
            {
                calories += item.Calories;
            }
            Console.WriteLine("В данном салате содержится " + calories + " ккал калорий.");
        }
        public void SortByProteins()
        {
            composition = composition.OrderBy(u => u.Proteins).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе белка!");
        }
        public void SortByFats()
        {
            composition = composition.OrderBy(u => u.Fats).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе жиров!");
        }
        public void SortByCarbohydrates()
        {
            composition = composition.OrderBy(u => u.Carbohydrates).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе углеводов!");
        }
        public void SortByCalories()
        {
            composition = composition.OrderBy(u => u.Calories).ToList();
            Console.WriteLine("Состав салата был отсортирован на основе калорий!");
        }
        public void ShowComposition()
        {
            Console.WriteLine("Состав салата \"" + Name + "\" включает в себя: ");
            if (composition.Count != 0)
            {
                foreach (var item in composition)
                {
                    Console.WriteLine(item.GetVegetableName() + " \"" + item.Sort + "\" " + item.Weight + " г.");
                }
            }
            else
            {
                Console.WriteLine("Пусто");
            }
        }
        public void FindCalories()
        {
            if (composition.Count != 0)
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
                    }
                    catch (Exception)
                    {
                        choose2 = null;
                        Console.WriteLine("Введено неккоректное значение!");
                    }
                }
                var selectedVegetables = composition.Where(v => (v.Calories >= num1) && (v.Calories <= num2)).OrderBy(v => v);
                if (selectedVegetables.Count() != 0)
                {
                    Console.WriteLine("Ингридиенты соответствующие заданному диапазону калорийности (" + num1 + " - " + num2 + "): ");
                    foreach (var item in selectedVegetables)
                    {
                        Console.WriteLine(item.GetVegetableName() + " \"" + item.Sort + "\" " + item.Calories + " ккал.");
                    }
                }
                else
                {
                    Console.WriteLine("Совпадений не найдено!");
                }
            }
            else
            {
                Console.WriteLine("В салате отсутствуют ингридиенты!");
            }
        }
    }
}
