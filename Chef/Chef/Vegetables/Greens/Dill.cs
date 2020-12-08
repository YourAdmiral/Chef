using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    internal class Dill : Green
    {
        private double mn;
        private double cr;
        private double co;
        public double Mn
        {
            get { return mn; }
            set
            {
                if (CheckDouble(value))
                    mn = value;
            }
        }
        public double Cr
        {
            get { return cr; }
            set
            {
                if (CheckDouble(value))
                    cr = value;
            }
        }
        public double Co
        {
            get { return co; }
            set
            {
                if (CheckDouble(value))
                    co = value;
            }
        }
        public Dill(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double mn, double cr, double co)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.mn = mn;
            this.cr = cr;
            this.co = co;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Марганец - " + Mn + " г.\n" +
                "Хром - " + Cr + " г.\n" +
                "Оксид углерода - " + Co + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали укроп...");
        }
        public override string GetVegetableName()
        {
            return "Укроп";
        }
    }
}
