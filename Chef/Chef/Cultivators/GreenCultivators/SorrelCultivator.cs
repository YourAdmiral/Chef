using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;

namespace Chef.Cultivators.GreenCultivators
{
    internal class SorrelCultivator : GreenCultivator
    {
        public override Green CultivateGreen()
        {
            return new Sorrel
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
