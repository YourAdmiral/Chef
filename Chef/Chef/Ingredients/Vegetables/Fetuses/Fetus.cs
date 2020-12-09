using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    internal abstract class Fetus : Vegetable
    {
        public Fetus(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {

        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Извлекли семечки...");
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Классификация:\nПлод.");
        }
    }
}
