﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Vegetables.Leafs
{
    internal abstract class Leaf : Vegetable
    {
        public Leaf(string sort, string color, double weight, double proteins, double fats, double carbohydrates, double calories, double water)
            : base(sort, color, weight, proteins, fats, carbohydrates, calories, water)
        {

        }
        public override void Handle()
        {
            base.Handle();
            Console.WriteLine("Cut the leaves...");
        }
        public override void ShowInformation()
        {
            base.ShowInformation();
            Console.WriteLine("Classification:\nLeaf.");
        }
    }
}
