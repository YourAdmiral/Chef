using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Spices;

namespace Chef.Cultivators.SpiceCultivators
{
    internal class SaltCultivator : SpiceCultivator
    {
        public override Spice CultivateSpice()
        {
            return new Salt
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteNa(),
                WriteCl(),
                WriteMo()
                );
        }
        protected double WriteNa()
        {
            Console.WriteLine("Введите количество натрия (г): ");
            return WriteDouble();
        }
        protected double WriteCl()
        {
            Console.WriteLine("Введите количество хлора (г): ");
            return WriteDouble();
        }
        protected double WriteMo()
        {
            Console.WriteLine("Введите количество молибдена (г): ");
            return WriteDouble();
        }
    }
}
