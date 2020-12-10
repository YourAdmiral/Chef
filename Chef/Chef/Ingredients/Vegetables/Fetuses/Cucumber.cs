using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    internal class Cucumber : Fetus
    {
        private double _k;
        private double _si;
        private double _cr;
        public double K 
        {
            get { return _k; }
            set
            {
                if (CheckDouble(value))
                    _k = value;
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
        public double Cr 
        {
            get { return _cr; }
            set
            {
                if (CheckDouble(value))
                    _cr = value;
            }
        }
        public Cucumber(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double k, double si, double cr)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._k = k;
            this._si = si;
            this._cr = cr;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins:\n" +
                $"Potassium - {K} г.\n" +
                $"Silicon - {Si} г.\n" +
                $"Chromium - {Cr} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Sliced a cucumber...");
        }
        public override string GetName()
        {
            return "Cucumber";
        }
    }
}
