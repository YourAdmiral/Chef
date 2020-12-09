using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    internal class Dill : Green
    {
        private double _mn;
        private double _cr;
        private double _co;
        public double Mn
        {
            get { return _mn; }
            set
            {
                if (CheckDouble(value))
                    _mn = value;
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
        public double Co
        {
            get { return _co; }
            set
            {
                if (CheckDouble(value))
                    _co = value;
            }
        }
        public Dill(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double mn, double cr, double co)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._mn = mn;
            this._cr = cr;
            this._co = co;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Марганец - {Mn} г.\n" +
                $"Хром - {Cr} г.\n" +
                $"Оксид углерода - {Co} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали укроп...");
        }
        public override string GetName()
        {
            return "Укроп";
        }
    }
}
