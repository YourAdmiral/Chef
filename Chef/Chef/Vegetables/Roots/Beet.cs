using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    class Beet : Root
    {
        double si;
        public double Si { get; set; }
        double cr;
        public double Cr { get; set; }
        double mn;
        public double Mn { get; set; }
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
                "Кремний - " + Si + " мг.\n" +
                "Хром - " + Cr + " мг.\n" +
                "Марганец - " + Mn + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали свеклу...");
        }
    }
}
