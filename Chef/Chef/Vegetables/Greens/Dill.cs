using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    class Dill : Green
    {
        double mn;
        public double Mn
        {
            get { return mn; }
            set
            {
                if (CheckDouble(value))
                    mn = value;
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
                "Марганец - " + Mn + " мг.\n" +
                "Хром - " + Cr + " мг.\n" +
                "Оксид углерода - " + Co + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали укроп...");
        }
    }
}
