using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    class Pepper : Fetus
    {
        double c;
        public double C 
        {
            get { return c; }
            set
            {
                if (CheckDouble(value))
                    c = value;
            }
        }
        double si;
        public double Si 
        {
            get { return si; }
            set
            {
                if (CheckDouble(value))
                    si = value;
            }
        }
        double cu;
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
    }
}
