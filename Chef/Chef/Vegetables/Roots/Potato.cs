using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    class Potato:Root
    {
        double k;
        public double K { get; set; }
        double si;
        public double Si { get; set; }
        double co;
        public double Co { get; set; }
        public Potato(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double k, double si, double co)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.k = k;
            this.si = si;
            this.co = co;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Калий - " + K + " мг.\n" +
                "Кремний - " + Si + " мг.\n" +
                "Углерод - " + Co + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали картофель...");
        }
    }
}
