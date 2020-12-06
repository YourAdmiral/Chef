using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    class Parsley : Green
    {
        double ca;
        public double Ca
        {
            get { return ca; }
            set
            {
                if (CheckDouble(value))
                    ca = value;
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
        double mg;
        public double Mg
        {
            get { return mg; }
            set
            {
                if (CheckDouble(value))
                    mg = value;
            }
        }
        public Parsley(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double si, double mg)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.ca = ca;
            this.si = si;
            this.mg = mg;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Кальций - " + Ca + " мг.\n" +
                "Кремний - " + Si + " мг.\n" +
                "Магний - " + Mg + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали петрушку...");
        }
    }
}
