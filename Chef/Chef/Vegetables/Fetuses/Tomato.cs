using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    class Tomato : Fetus
    {
        double co;
        public double Co { get; set; }
        double si;
        public double Si { get; set; }
        double c;
        public double C { get; set; }
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
            Console.WriteLine("Минералы и витамины:\n" +
                "Оксид углерода - " + Co + " мг.\n" +
                "Кремний - " + Si + " мг.\n" +
                "Углерод - " + C + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали томат...");
        }
    }
}
