using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    internal class Kohlrabi : Leaf
    {
        private double ca;
        private double mg;
        private double p;
        public double Ca 
        {
            get 
            { 
                return ca; 
            }
            set
            {
                if (CheckDouble(value))
                    ca = value;
            }
        }
        public double Mg 
        {
            get { return mg; }
            set
            {
                if (CheckDouble(value))
                    mg = value;
            }
        }
        public double P 
        {
            get { return p; }
            set
            {
                if (CheckDouble(value))
                    p = value;
            }
        }
        public Kohlrabi(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double mg, double p)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.ca = ca;
            this.mg = mg;
            this.p = p;
        }
        public override void GetInformation()
        {
            base.GetInformation();
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
