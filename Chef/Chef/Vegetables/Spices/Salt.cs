﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Spices
{
    class Salt : Spice
    {
        double na;
        public double Na
        {
            get
            {
                return na;
            }
            set
            {
                if (CheckDouble(value))
                    na = value;
            }
        }
        double cl;
        public double Cl
        {
            get { return cl; }
            set
            {
                if (CheckDouble(value))
                    cl = value;
            }
        }
        double mo;
        public double Mo
        {
            get { return mo; }
            set
            {
                if (CheckDouble(value))
                    mo = value;
            }
        }
        public Salt(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double na, double cl, double mo)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.na = na;
            this.cl = cl;
            this.mo = mo;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Натрий - " + Na + " мг.\n" +
                "Хлор - " + Cl + " мг.\n" +
                "Марганец - " + Mo + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Насыпали соли...");
        }
    }
}