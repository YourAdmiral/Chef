using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    internal class Sorrel : Green
    {
        private double _mg;
        private double _cu;
        private double _p;
        public double Mg
        {
            get { return _mg; }
            set
            {
                if (CheckDouble(value))
                    _mg = value;
            }
        }
        public double Cu
        {
            get { return _cu; }
            set
            {
                if (CheckDouble(value))
                    _cu = value;
            }
        }
        public double P
        {
            get { return _p; }
            set
            {
                if (CheckDouble(value))
                    _p = value;
            }
        }
        public Sorrel(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double mg, double cu, double p)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._mg = mg;
            this._cu = cu;
            this._p = p;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Магний - {Mg} г.\n" +
                $"Медь - {Cu} г.\n" +
                $"Фосфор - {P} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали щавель...");
        }
        public override string GetName()
        {
            return "Щавель";
        }
    }
}
