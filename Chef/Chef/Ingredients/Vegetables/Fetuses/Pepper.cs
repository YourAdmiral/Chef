using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    internal class Pepper : Fetus
    {
        private double _c;
        private double _si;
        private double _cu;
        public double C 
        {
            get { return _c; }
            set
            {
                if (CheckDouble(value))
                    _c = value;
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
        public double Cu 
        {
            get { return _cu; }
            set
            {
                if (CheckDouble(value))
                    _cu = value;
            }
        }
        public Pepper(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double c, double si, double cu)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._c = c;
            this._si = si;
            this._cu = cu;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Углерод - {C} г.\n" +
                $"Кремний - {Si} г.\n" +
                $"Медь - {Cu} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали перец...");
        }
        public override string GetName()
        {
            return "Перец";
        }
    }
}
