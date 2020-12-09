using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    internal class Salt : Spice
    {
        private double na;
        private double cl;
        private double mo;
        public double Na
        {
            get
            {
                return na;
            }
            set
            {
                if (CheckDouble(value))
                    na = value;
            }
        }
        public double Cl
        {
            get { return cl; }
            set
            {
                if (CheckDouble(value))
                    cl = value;
            }
        }
        public double Mo
        {
            get { return mo; }
            set
            {
                if (CheckDouble(value))
                    mo = value;
            }
        }
        public Salt(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double na, double cl, double mo)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.na = na;
            this.cl = cl;
            this.mo = mo;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Минералы и витамины: \n" +
                $"Натрий - {Na} г.\n" +
                $"Хлор - {Cl} г.\n" +
                $"Марганец - {Mo} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Насыпали соли...");
        }
        public override string GetName()
        {
            return "Соль";
        }
    }
}
