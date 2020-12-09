using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    internal class Sugar : Spice
    {
        private double ca;
        private double na;
        private double fe;
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
        public double Na
        {
            get { return na; }
            set
            {
                if (CheckDouble(value))
                    na = value;
            }
        }
        public double Fe
        {
            get { return fe; }
            set
            {
                if (CheckDouble(value))
                    fe = value;
            }
        }
        public Sugar(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double na, double fe)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.ca = ca;
            this.na = na;
            this.fe = fe;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Кальций - {Ca} г.\n" +
                $"Натрий - {Na} г.\n" +
                $"Железо - {Fe} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Насыпали сахара...");
        }
        public override string GetName()
        {
            return "Сахар";
        }
    }
}
