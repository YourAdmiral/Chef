using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    internal class Parsley : Green
    {
        private double ca;
        private double si;
        private double mg;
        public double Ca
        {
            get { return ca; }
            set
            {
                if (CheckDouble(value))
                    ca = value;
            }
        }
        public double Si
        {
            get { return si; }
            set
            {
                if (CheckDouble(value))
                    si = value;
            }
        }
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
                "Кальций - " + Ca + " г.\n" +
                "Кремний - " + Si + " г.\n" +
                "Магний - " + Mg + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали петрушку...");
        }
        public override string GetVegetableName()
        {
            return "Петрушка";
        }
    }
}
