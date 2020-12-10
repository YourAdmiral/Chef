using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    internal class Salt : Spice
    {
        private double _na;
        private double _cl;
        private double _mo;
        public double Na
        {
            get
            {
                return _na;
            }
            set
            {
                if (CheckDouble(value))
                    _na = value;
            }
        }
        public double Cl
        {
            get { return _cl; }
            set
            {
                if (CheckDouble(value))
                    _cl = value;
            }
        }
        public double Mo
        {
            get { return _mo; }
            set
            {
                if (CheckDouble(value))
                    _mo = value;
            }
        }
        public Salt(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double na, double cl, double mo)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._na = na;
            this._cl = cl;
            this._mo = mo;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins: \n" +
                $"Sodium - {Na} г.\n" +
                $"Chlorine - {Cl} г.\n" +
                $"Manganese - {Mo} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Poured salt...");
        }
        public override string GetName()
        {
            return "Salt";
        }
    }
}
