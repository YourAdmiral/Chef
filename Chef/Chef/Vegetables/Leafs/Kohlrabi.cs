using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    class Kohlrabi : Leaf
    {
        double ca;
        public double Ca { get; set; }
        double mg;
        public double Mg { get; set; }
        double p;
        public double P { get; set; }
        public Kohlrabi(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double ca, double mg, double p)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.ca = ca;
            this.mg = mg;
            this.p = p;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Кальций - " + Ca + " мг.\n" +
                "Магний - " + Mg + " мг.\n" +
                "Фосфор - " + P + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нашинковали кольраби...");
        }
    }
}
