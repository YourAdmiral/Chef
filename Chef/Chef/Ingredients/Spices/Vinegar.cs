using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    internal class Vinegar : Spice
    {
        private double _ca;
        private double _mg;
        private double _na;
        public double Ca
        {
            get
            {
                return _ca;
            }
            set
            {
                if (CheckDouble(value))
                    Ca = value;
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
        public double Na
        {
            get { return _na; }
            set
            {
                if (CheckDouble(value))
                    _na = value;
            }
        }
        public Vinegar(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double mg, double na)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._ca = ca;
            this._mg = mg;
            this._na = na;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Кальций - {Ca} г.\n" +
                $"Магний - {Mg} г.\n" +
                $"Натрий - {Na} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Налили уксуса...");
        }
        public override string GetName()
        {
            return "Уксус";
        }
    }
}
