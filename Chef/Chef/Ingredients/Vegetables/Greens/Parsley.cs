using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    internal class Parsley : Green
    {
        private double _ca;
        private double _si;
        private double _mg;
        public double Ca
        {
            get { return _ca; }
            set
            {
                if (CheckDouble(value))
                    _ca = value;
            }
        }
        public double Si
        {
            get { return _si; }
            set
            {
                if (CheckDouble(value))
                    _si = value;
            }
        }
        public double Mg
        {
            get { return _mg; }
            set
            {
                if (CheckDouble(value))
                    _mg = value;
            }
        }
        public Parsley(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double si, double mg)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._ca = ca;
            this._si = si;
            this._mg = mg;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins:\n" +
                $"Calcium - {Ca} г.\n" +
                $"Silicon - {Si} г.\n" +
                $"Magnesium - {Mg} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Chopped parsley...");
        }
        public override string GetName()
        {
            return "Parsley";
        }
    }
}
