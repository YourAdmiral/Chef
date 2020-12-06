using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    class Broccoli : Leaf
    {
        double fe;
        public double Fe 
        {
            get { return fe; }
            set
            {
                if (CheckDouble(value))
                    fe = value;
            }
        }
        double i;
        public double I 
        {
            get { return i; }
            set
            {
                if (CheckDouble(value))
                    i = value;
            }
        }
        double mn;
        public double Mn {
            get { return mn; }
            set
            {
                if (CheckDouble(value))
                    mn = value;
            }
        }
        public Broccoli(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double fe, double i, double mn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.fe = fe;
            this.i = i;
            this.mn = mn;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Железо - " + Fe + " г.\n" +
                "Йод - " + I + " г.\n" +
                "Марганец - " + Mn + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нашинковали брокколи...");
        }
    }
}
