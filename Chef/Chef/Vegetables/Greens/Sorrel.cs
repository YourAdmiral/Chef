﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Greens
{
    class Sorrel : Green
    {
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
        double cu;
        public double Cu
        {
            get { return cu; }
            set
            {
                if (CheckDouble(value))
                    cu = value;
            }
        }
        double p;
        public double P
        {
            get { return p; }
            set
            {
                if (CheckDouble(value))
                    p = value;
            }
        }
        public Sorrel(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double mg, double cu, double p)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.mg = mg;
            this.cu = cu;
            this.p = p;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Магний - " + Mg + " г.\n" +
                "Медь - " + Cu + " г.\n" +
                "Фосфор - " + P + " г.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали щавель...");
        }
    }
}
