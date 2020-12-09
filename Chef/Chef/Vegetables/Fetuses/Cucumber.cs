using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Fetuses
{
    internal class Cucumber : Fetus
    {
        private double k;
        private double si;
        private double cr;
        public double K 
        {
            get { return k; }
            set
            {
                if (CheckDouble(value))
                    k = value;
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
        public double Cr 
        {
            get { return cr; }
            set
            {
                if (CheckDouble(value))
                    cr = value;
            }
        }
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
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Калий - {K} г.\n" +
                $"Кремний - {Si} г.\n" +
                $"Хром - {Cr} г.");
        }
        public override void Handle()
        {
            Console.WriteLine("---Подготавливаем огурец---");
            base.Handle();
            Console.WriteLine("Нарезали огурец...");
        }
        public override string GetName()
        {
            return "Огурец";
        }
    }
}
