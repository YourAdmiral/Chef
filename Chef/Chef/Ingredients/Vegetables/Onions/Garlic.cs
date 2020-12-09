using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Onions
{
    internal class Garlic : Onion
    {
        private double _co;
        private double _cr;
        private double _mn;
        public double Co
        {
            get { return _co; }
            set
            {
                if (CheckDouble(value))
                    _co = value;
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
        public Garlic(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double cr, double mn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._co = co;
            this._cr = cr;
            this._mn = mn;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Оксид углерода - {Co} г.\n" +
                $"Хром - {Cr} г.\n" +
                $"Марганец - {Mn} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали чеснок...");
        }
        public override string GetName()
        {
            return "Чеснок";
        }
    }
}
