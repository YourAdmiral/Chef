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
            Console.WriteLine($"Тип ингредиента:\nОвощ");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine($"Очистили от пыли и грязи...");
        }
    }
}
