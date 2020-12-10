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
        private IList<Ingredient> _composition = new List<Ingredient>();
        public Salad(string name)
        {
            Name = name;
        }
        public Salad(string name, IList<Ingredient> composition)
        {
            Name = name;
            AddIngredients(composition);
        }
        public void AddIngredient(Ingredient ingredient)
        {
            _composition.Add(ingredient);
            ingredient.Handle();
        }
        public void AddIngredients(IList<Ingredient> vegetables)
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
            Console.WriteLine($"This salad contains {calories} kcal calories.");
        }
        public void SortByProteins()
        {
            _composition = _composition.OrderBy(u => u.Proteins).ToList();
            Console.WriteLine("The salad was sorted based on protein!");
        }
        public void SortByFats()
        {
            _composition = _composition.OrderBy(u => u.Fats).ToList();
            Console.WriteLine("The composition of the salad was sorted based on fat!");
        }
        public void SortByCarbohydrates()
        {
            _composition = _composition.OrderBy(u => u.Carbohydrates).ToList();
            Console.WriteLine("The salad was sorted based on carbohydrates!");
        }
        public void SortByCalories()
        {
            _composition = _composition.OrderBy(u => u.Calories).ToList();
            Console.WriteLine("The salad was sorted based on calories!");
        }
        public void ShowComposition()
        {
            Console.WriteLine($"Composition of \"{Name}\" includes: ");
            if (_composition.Count != 0)
            {
                foreach (var item in _composition)
                {
                    Console.WriteLine($"{item.GetName()} \"{item.Sort}\" {item.Weight} г.");
                }
            }
            else
            {
                Console.WriteLine("Empty");
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
                Console.WriteLine("Enter the minimum of calories: ");
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
                        Console.WriteLine("Incorrect value entered!");
                    }
                }
                Console.WriteLine("Enter the maximum of calories: ");
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
                        Console.WriteLine("Incorrect value entered!");
                    }
                }
                var selectedVegetables = _composition.Where(v => (v.Calories >= num1) && (v.Calories <= num2));
                if (selectedVegetables.Count() != 0)
                {
                    Console.WriteLine($"Ingredients within the calories range ({num1} - {num2}): ");
                    foreach (Ingredient item in selectedVegetables)
                    {
                        Console.WriteLine($"{item.GetName()} \"{item.Sort}\" {item.Calories} kcal.");
                    }
                }
                else
                {
                    Console.WriteLine("Not found!");
                }
            }
            else
            {
                Console.WriteLine("The salad is missing ingredients!");
            }
        }
    }
}
