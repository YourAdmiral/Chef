using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Onions
{
    internal class NapiformOnion : Onion
    {
        private double _co;
        private double _si;
        private double _c;
        public double Co
        {
            get { return _co; }
            set
            {
                if (CheckDouble(value))
                    _co = value;
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
        public double C
        {
            get { return _c; }
            set
            {
                if (CheckDouble(value))
                    _c = value;
            }
        }
        public NapiformOnion(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double si, double c)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._co = co;
            this._si = si;
            this._c = c;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins:\n" +
                $"Carbon monoxide - {Co} г.\n" +
                $"Silicon - {Si} г.\n" +
                $"Carbon - {C} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Cut napiform onion...");
        }
        public override string GetName()
        {
            return "Napiform onion";
        }
    }
}
