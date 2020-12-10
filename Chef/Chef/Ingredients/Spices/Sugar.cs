using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    internal class Sugar : Spice
    {
        private double _ca;
        private double _na;
        private double _fe;
        public double Ca
        {
            get
            {
                return _ca;
            }
            set
            {
                if (CheckDouble(value))
                    Ca = value;
            }
        }
        public double Na
        {
            get { return _na; }
            set
            {
                if (CheckDouble(value))
                    _na = value;
            }
        }
        public double Fe
        {
            get { return _fe; }
            set
            {
                if (CheckDouble(value))
                    _fe = value;
            }
        }
        public Sugar(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double na, double fe)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._ca = ca;
            this._na = na;
            this._fe = fe;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins:\n" +
                $"Calcium - {Ca} г.\n" +
                $"Sodium - {Na} г.\n" +
                $"Iron - {Fe} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Poured sugar...");
        }
        public override string GetName()
        {
            return "Sugar";
        }
    }
}
