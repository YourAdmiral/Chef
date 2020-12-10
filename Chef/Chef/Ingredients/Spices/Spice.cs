using System;
using System.Collections.Generic;
using Chef.Ingredients;

namespace Chef.Vegetables.Spices
{
    internal abstract class Spice : Ingredient
    {
        public Spice(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
          : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {

        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Used a spice processing machine...");
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Ingredient type:\nSpice.");
        }
    }
}
