using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Onions
{
    internal class Garlic : Onion
    {
        private double co;
        private double cr;
        private double mn;
        public double Co
        {
            get { return co; }
            set
            {
                if (CheckDouble(value))
                    co = value;
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
        public double Mn
        {
            get { return mn; }
            set
            {
                if (CheckDouble(value))
                    mn = value;
            }
        }
        public Garlic(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double cr, double mn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.co = co;
            this.cr = cr;
            this.mn = mn;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Оксид углерода - " + Co + " г.\n" +
                "Хром - " + Cr + " г.\n" +
                "Марганец - " + Mn + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали чеснок...");
        }
        public override string GetName()
        {
            return "Чеснок";
        }
    }
}
