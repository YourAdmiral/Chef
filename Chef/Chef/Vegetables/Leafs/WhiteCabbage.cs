using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    class WhiteCabbage : Leaf
    {
        double co;
        public double Co 
        {
            get { return co; }
            set
            {
                if (CheckDouble(value))
                    co = value;
            }
        }
        double mo;
        public double Mo 
        {
            get { return mo; }
            set
            {
                if (CheckDouble(value))
                    mo = value;
            }
        }
        double cr;
        public double Cr 
        {
            get { return cr; }
            set
            {
                if (CheckDouble(value))
                    cr = value;
            }
        }
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
                "Оксид углерода - " + Co + " г.\n" +
                "Молибден - " + Mo + " г.\n" +
                "Хром - " + Cr + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нашинковали капусту...");
        }
    }
}
