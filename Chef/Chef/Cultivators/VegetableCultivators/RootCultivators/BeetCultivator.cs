﻿using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Roots;

namespace Chef.Cultivators.RootCultivators
{
    internal class BeetCultivator : RootCultivator
    {
        public override Root CultivateRoot()
        {
            return new Beet
                (
                GetSort(),
                GetColor(),
                GetWeight(),
                GetProteins(),
                GetFats(),
                GetCarbohydrates(),
                GetCalories(),
                GetWater(),
                GetSi(),
                GetCr(),
                GetMn()
                );
        }
        protected double GetSi()
        {
            Console.WriteLine("Enter the amount of silicon (g): ");
            return GetDouble();
        }
        protected double GetCr()
        {
            Console.WriteLine("Enter the amount of chromium (g): ");
            return GetDouble();
        }
        protected double GetMn()
        {
            Console.WriteLine("Enter the amount of manganese (g): ");
            return GetDouble();
        }
    }
}
