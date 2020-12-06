using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    class WhiteCabbage : Leaf
    {
        double co;
        public double Co { get; set; }
        double mo;
        public double Mo { get; set; }
        double cr;
        public double Cr { get; set; }
        public WhiteCabbage(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double mo, double cr)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.co = co;
            this.mo = mo;
            this.cr = cr;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Оксид углерода - " + Co + " мг.\n" +
                "Молибден - " + Mo + " мг.\n" +
                "Хром - " + Cr + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нашинковали капусту...");
        }
    }
}
