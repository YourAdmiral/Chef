using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    internal class Carrot : Root
    {
        private double si;
        private double mo;
        private double co;
        public double Si 
        {
            get { return si; }
            set
            {
                if (CheckDouble(value))
                    si = value;
            }
        }
        public double Mo 
        {
            get { return mo; }
            set
            {
                if (CheckDouble(value))
                    mo = value;
            }
        }
        public double Co 
        {
            get { return co; }
            set
            {
                if (CheckDouble(value))
                    co = value;
            }
        }
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
                "Кремний - " + Si + " г.\n" +
                "Молибден - " + Mo + " г.\n" +
                "Оксид углерода - " + Co + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали морковь...");
        }
        public override string GetVegetableName()
        {
            return "Морковь";
        }
    }
}
