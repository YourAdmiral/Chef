using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.GreenCultivators
{
    internal class SorrelCultivator : GreenCultivator
    {
        public override Vegetables.Greens.Green CultivateGreen()
        {
            return new Vegetables.Greens.Sorrel
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteMg(),
                WriteCu(),
                WriteP()
                );
        }
        protected double WriteMg()
        {
            Console.WriteLine("Введите количество магния (г): ");
            return WriteDouble();
        }
        protected double WriteCu()
        {
            Console.WriteLine("Введите количество меди (г): ");
            return WriteDouble();
        }
        protected double WriteP()
        {
            Console.WriteLine("Введите количество фосфора (г): ");
            return WriteDouble();
        }
    }
}
