using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    internal class Broccoli : Leaf
    {
        private double _fe;
        private double _i;
        private double _mn;
        public double Fe 
        {
            get { return _fe; }
            set
            {
                if (CheckDouble(value))
                    _fe = value;
            }
        }
        public double I 
        {
            get { return _i; }
            set
            {
                if (CheckDouble(value))
                    _i = value;
            }
        }
        public double Mn {
            get { return _mn; }
            set
            {
                if (CheckDouble(value))
                    _mn = value;
            }
        }
        public Broccoli(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double fe, double i, double mn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._fe = fe;
            this._i = i;
            this._mn = mn;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins:\n" +
                $"Iron - {Fe} г.\n" +
                $"Iodine - {I} г.\n" +
                $"Manganese - {Mn} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Chopped broccoli...");
        }
        public override string GetName()
        {
            return "Broccoli";
        }
    }
}
