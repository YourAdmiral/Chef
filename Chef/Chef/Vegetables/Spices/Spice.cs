using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    internal abstract class Spice : Vegetable
    {
        public Spice(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
          : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {

        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Использовали машину для обработки специй...");
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Классификация:\nСпеция.");
        }
    }
}
