using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    internal class WhiteCabbage : Leaf
    {
        private double _co;
        private double _mo;
        private double _cr;
        public double Co 
        {
            get { return _co; }
            set
            {
                if (CheckDouble(value))
                    _co = value;
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
        public double Cr 
        {
            get { return _cr; }
            set
            {
                if (CheckDouble(value))
                    _cr = value;
            }
        }
        public WhiteCabbage(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double mo, double cr)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._co = co;
            this._mo = mo;
            this._cr = cr;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Оксид углерода - {Co} г.\n" +
                $"Молибден - {Mo} г.\n" +
                $"Хром - {Cr} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нашинковали капусту...");
        }
        public override string GetName()
        {
            return "Белокочанная капуста";
        }
    }
}
