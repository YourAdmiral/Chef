using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    class Cucumber : Fetus
    {
        double k;
        public double K { get; set; }
        double si;
        public double Si { get; set; }
        double cr;
        public double Cr { get; set; }
        public Cucumber(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double k, double si, double cr)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.k = k;
            this.si = si;
            this.cr = cr;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Калий - " + K + " мг.\n" +
                "Кремний - " + Si + " мг.\n" +
                "Хром - " + Cr + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали огурец...");
        }
    }
}
