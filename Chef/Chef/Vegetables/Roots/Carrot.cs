using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    class Carrot : Root
    {
        double si;
        public double Si { get; set; }
        double mo;
        public double Mo { get; set; }
        double co;
        public double Co { get; set; }
        public Carrot(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double si, double mo, double co)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.si = si;
            this.mo = mo;
            this.co = co;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Кремний - " + Si + " мг.\n" +
                "Молибден - " + Mo + " мг.\n" +
                "Оксид углерода - " + Co + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали морковь...");
        }
    }
}
