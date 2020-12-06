﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.RootCultivators
{
    class BeetCultivator : RootCultivator
    {
        public override Vegetables.Roots.Root CultivateRoot()
        {
            return new Vegetables.Roots.Beet
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteSi(),
                WriteCr(),
                WriteMn()
                );
        }
        protected double WriteSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return WriteDouble();
        }
        protected double WriteCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return WriteDouble();
        }
        protected double WriteMn()
        {
            Console.WriteLine("Введите количество марганца (г): ");
            return WriteDouble();
        }
    }
}