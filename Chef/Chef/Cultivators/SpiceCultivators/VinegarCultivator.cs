using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class VinegarCultivator : SpiceCultivator
    {
        public override Vegetables.Spices.Spice CultivateSpice()
        {
            return new Vegetables.Spices.Vinegar
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
                WriteMg(),
                WriteNa()
                );
        }
        protected double WriteCa()
        {
            Console.WriteLine("Введите количество кальция (г): ");
            return WriteDouble();
        }
        protected double WriteMg()
        {
            Console.WriteLine("Введите количество магния (г): ");
            return WriteDouble();
        }
        protected double WriteNa()
        {
            Console.WriteLine("Введите количество натрия (г): ");
            return WriteDouble();
        }
    }
}
