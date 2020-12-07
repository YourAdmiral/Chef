using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    class Beet : Root
    {
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
        double cr;
        public double Cr 
        {
            get { return cr; }
            set
            {
                if (CheckDouble(value))
                    cr = value;
            }
        }
        double mn;
        public double Mn 
        {
            get { return mn; }
            set
            {
                if (CheckDouble(value))
                    mn = value;
            }
        }
        public Beet(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double si, double cr, double mn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.si = si;
            this.cr = cr;
            this.mn = mn;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Кремний - " + Si + " г.\n" +
                "Хром - " + Cr + " г.\n" +
                "Марганец - " + Mn + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали свеклу...");
        }

        public override string GetVegetableName()
        {
            return "Свекла";
        }
    }
}
