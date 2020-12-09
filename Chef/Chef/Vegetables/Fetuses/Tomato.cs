using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    internal class Tomato : Fetus
    {
        private double co;
        private double si;
        private double c;
        public double Co 
        {
            get { return co; }
            set
            {
                if (CheckDouble(value))
                    co = value;
            }
        }
        public double Si 
        {
            get { return si; }
            set
            {
                if (CheckDouble(value))
                    si = value;
            }
        }
        public double C 
        {
            get { return c; }
            set
            {
                if (CheckDouble(value))
                    c = value;
            }
        }
        public Tomato(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double si, double c)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.co = co;
            this.si = si;
            this.c = c;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Оксид углерода - {Co} г.\n" +
                $"Кремний - {Si} г.\n" +
                $"Углерод - {C} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали томат...");
        }
        public override string GetName()
        {
            return "Томат";
        }
    }
}
