using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    internal class Beet : Root
    {
        private double _si;
        private double _cr;
        private double _mn;
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
        public double Mn 
        {
            get { return _mn; }
            set
            {
                if (CheckDouble(value))
                    _mn = value;
            }
        }
        public Beet(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double si, double cr, double mn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._si = si;
            this._cr = cr;
            this._mn = mn;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Minerals and vitamins:\n" +
                $"Silicon - {Si} г.\n" +
                $"Chromium - {Cr} г.\n" +
                $"Manganese - {Mn} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Cut beet...");
        }
        public override string GetName()
        {
            return "Beet";
        }
    }
}
