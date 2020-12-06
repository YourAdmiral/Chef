using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.GreenCultivators
{
    class ParsleyCultivator : GreenCultivator
    {
        public override Vegetables.Greens.Green CultivateGreen()
        {
            return new Vegetables.Greens.Parsley
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
                WriteSi(),
                WriteMg()
                );
        }
        protected double WriteCa()
        {
            Console.WriteLine("Введите количество кальция (г): ");
            return WriteDouble();
        }
        protected double WriteSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return WriteDouble();
        }
        protected double WriteMg()
        {
            Console.WriteLine("Введите количество магния (г): ");
            return WriteDouble();
        }
    }
}
