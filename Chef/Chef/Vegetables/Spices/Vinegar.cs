using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    internal class Vinegar : Spice
    {
        private double ca;
        private double mg;
        private double na;
        public double Ca
        {
            get
            {
                return ca;
            }
            set
            {
                if (CheckDouble(value))
                    Ca = value;
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
        public double Na
        {
            get { return na; }
            set
            {
                if (CheckDouble(value))
                    na = value;
            }
        }
        public Vinegar(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double mg, double na)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.ca = ca;
            this.mg = mg;
            this.na = na;
        }
        public override void GetInformation()
        {
            base.GetInformation();
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
