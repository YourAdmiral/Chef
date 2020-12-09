using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;

namespace Chef.Cultivators.GreenCultivators
{
    internal class ParsleyCultivator : GreenCultivator
    {
        public override Green CultivateGreen()
        {
            return new Parsley
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
