using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    class Pepper : Fetus
    {
        double c;
        public double C { get; set; }
        double si;
        public double Si { get; set; }
        double cu;
        public double Cu { get; set; }
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
                "Углерод - " + C + " мг.\n" +
                "Кремний - " + Si + " мг.\n" +
                "Медь - " + Cu + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали перец...");
        }
    }
}
