using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Chef.Manager
{
    class Salad
    {
        public string Name { get; set; }
        List<Vegetables.Vegetable> composition = new List<Vegetables.Vegetable>();
        public Salad(string name)
        {
            Name = name;
        }
        public Salad(string name, List<Vegetables.Vegetable> composition)
        {
            Name = name;
            composition.AddRange(composition);
        }
        public void AddVegetable(Vegetables.Vegetable vegetable)
        {
            composition.Add(vegetable);
            vegetable.Handle();
        }
        public void AddVegetables(List<Vegetables.Vegetable> vegetables)
        {
            composition.AddRange(vegetables);
            foreach (var item in vegetables)
            {
                item.Handle();
            }
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
        public void FindCalories(double num1, double num2)
        {
            Console.WriteLine("Овощи соответствующие заданному диапазону калорийности: ");
            if (composition.Count!=0)
            {
                var selectedVegetables = composition.Where(v => (v.Calories >= num1) && (v.Calories <= num2)).OrderBy(v => v);
                foreach (var item in selectedVegetables)
                {
                    Console.WriteLine(item.GetVegetableName() + " \"" + item.Sort + "\" " + item.Calories + " г.");
                }
            }
            else
            {
                Console.WriteLine("Пусто");
            }
        }
    }
}
