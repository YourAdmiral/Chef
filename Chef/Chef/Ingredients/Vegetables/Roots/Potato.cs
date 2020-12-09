using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Roots
{
    internal class Potato:Root
    {
        private double _k;
        private double _si;
        private double _co;
        public double K 
        {
            get { return _k; }
            set
            {
                if (CheckDouble(value))
                    _k = value;
            }
        }
        public double Si 
        {
            get { return _si; }
            set
            {
                if (CheckDouble(value))
                    _si = value;
            }
        }
        public double Co 
        {
            get { return _co; }
            set
            {
                if (CheckDouble(value))
                    _co = value;
            }
        }
        public Potato(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double k, double si, double co)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this._k = k;
            this._si = si;
            this._co = co;
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine($"Минералы и витамины:\n" +
                $"Калий - {K} г.\n" +
                $"Кремний - {Si} г.\n" +
                $"Углерод - {Co} г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали картофель...");
        }
        public override string GetName()
        {
            return "Картофель";
        }
    }
}
