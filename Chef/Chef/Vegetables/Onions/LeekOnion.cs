﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Onions
{
    class LeekOnion : Onion
    {
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
        double zn;
        public double Zn
        {
            get { return zn; }
            set
            {
                if (CheckDouble(value))
                    zn = value;
            }
        }
        public LeekOnion(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water, double co, double si, double zn)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {
            this.co = co;
            this.si = si;
            this.zn = zn;
        }
        public override void GetInformation()
        {
            base.GetInformation();
            Console.WriteLine("Минералы и витамины:\n" +
                "Оксид углерода - " + Co + " мг.\n" +
                "Кремний - " + Si + " мг.\n" +
                "Цинк - " + Zn + " мг.");
        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Нарезали лук-порей...");
        }
    }
}