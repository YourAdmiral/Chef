using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Onions
{
    internal class LeekOnion : Onion
    {
        private double _co;
        private double _si;
        private double _zn;
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
        public double Zn
        {
            get { return _zn; }
            set
            {
                if (CheckDouble(value))
                    _zn = value;
            }
        }
        public LeekOnion(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double si, double zn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._co = co;
            this._si = si;
            this._zn = zn;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins:\n" +
                $"Carbon monoxide - {Co} г.\n" +
                $"Silicon - {Si} г.\n" +
                $"Zinc - {Zn} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Cut leek onion...");
        }
        public override string GetName()
        {
            return "Leek onion";
        }
    }
}
