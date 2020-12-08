using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    internal class Pepper : Fetus
    {
        private double c;
        private double si;
        private double cu;
        public double C 
        {
            get { return c; }
            set
            {
                if (CheckDouble(value))
                    c = value;
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
        public double Cu 
        {
            get { return cu; }
            set
            {
                if (CheckDouble(value))
                    cu = value;
            }
        }
        public Pepper(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double c, double si, double cu)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.c = c;
            this.si = si;
            this.cu = cu;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Углерод - " + C + " г.\n" +
                "Кремний - " + Si + " г.\n" +
                "Медь - " + Cu + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали перец...");
        }
        public override string GetVegetableName()
        {
            return "Перец";
        }
    }
}
