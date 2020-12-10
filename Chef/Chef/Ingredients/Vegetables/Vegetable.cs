using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables
{
    internal abstract class Vegetable : Ingredients.Ingredient
    {
        protected Vegetable(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {

        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Ingredient type:\nVegetable");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine($"Remove dust and dirt...");
        }
    }
}
