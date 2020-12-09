using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    internal class Kohlrabi : Leaf
    {
        private double _ca;
        private double _mg;
        private double _p;
        public double Ca 
        {
            get 
            { 
                return _ca; 
            }
            set
            {
                if (CheckDouble(value))
                    _ca = value;
            }
        }
        public double Mg 
        {
            get { return _mg; }
            set
            {
                if (CheckDouble(value))
                    _mg = value;
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
        public Kohlrabi(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double mg, double p)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._ca = ca;
            this._mg = mg;
            this._p = p;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Кальций - {Ca} г.\n" +
                $"Магний - {Mg} г.\n" +
                $"Фосфор - {P} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нашинковали кольраби...");
        }
        public override string GetName()
        {
            return "Кольраби";
        }
    }
}
