using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Onions
{
    internal abstract class Onion : Vegetable
    {
        public Onion(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {

        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Очистили луковицу от чешуек...");
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Классификация:\nЛуковое.");
        }
    }
}
