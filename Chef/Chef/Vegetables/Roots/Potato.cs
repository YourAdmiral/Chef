using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    class Potato:Root
    {
        double k;
        public double K 
        {
            get { return k; }
            set
            {
                if (CheckDouble(value))
                    k = value;
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
        double co;
        public double Co 
        {
            get { return co; }
            set
            {
                if (CheckDouble(value))
                    co = value;
            }
        }
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
