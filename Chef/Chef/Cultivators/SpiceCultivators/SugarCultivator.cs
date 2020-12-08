using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class SugarCultivator:SpiceCultivator
    {
        public override Vegetables.Spices.Spice CultivateSpice()
        {
            return new Vegetables.Spices.Sugar
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteCa(),
                WriteNa(),
                WriteFe()
                );
        }
        protected double WriteCa()
        {
            Console.WriteLine("Введите количество кальция (г): ");
            return WriteDouble();
        }
        protected double WriteNa()
        {
            Console.WriteLine("Введите количество натрия (г): ");
            return WriteDouble();
        }
        protected double WriteFe()
        {
            Console.WriteLine("Введите количество железа (г): ");
            return WriteDouble();
        }
    }
}
