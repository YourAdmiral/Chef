using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.SpiceCultivators
{
    class SaltCultivator : SpiceCultivator
    {
        public override Vegetables.Spices.Spice CultivateSpice()
        {
            return new Vegetables.Spices.Salt
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
