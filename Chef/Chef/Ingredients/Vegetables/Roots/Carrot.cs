using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    internal class Carrot : Root
    {
        private double _si;
        private double _mo;
        private double _co;
        public double Si 
        {
            get { return _si; }
            set
            {
                if (CheckDouble(value))
                    _si = value;
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
        public double Co 
        {
            get { return _co; }
            set
            {
                if (CheckDouble(value))
                    _co = value;
            }
        }
        public Carrot(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double si, double mo, double co)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._si = si;
            this._mo = mo;
            this._co = co;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Minerals and vitamins: \n" +
                $"Silicon - {Si} г.\n" +
                $"Molybdenum - {Mo} г.\n" +
                $"Carbon monoxide - {Co} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Cut carrot...");
        }
        public override string GetName()
        {
            return "Carrot";
        }
    }
}
