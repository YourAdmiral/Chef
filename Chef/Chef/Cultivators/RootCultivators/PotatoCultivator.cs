using Chef.Vegetables.Roots;
using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.RootCultivators
{
    class PotatoCultivator : RootCultivator
    {
        public override Root CultivateRoot()
        {
            return new Potato
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteK(),
                WriteSi(),
                WriteCo()
                );
        }
        protected double WriteK()
        {
            Console.WriteLine("Введите количество калия (г): ");
            return WriteDouble();
        }
        protected double WriteSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return WriteDouble();
        }
        protected double WriteCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return WriteDouble();
        }
    }
}
