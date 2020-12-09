using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Greens;

namespace Chef.Cultivators.GreenCultivators
{
    internal class DillCultivator : GreenCultivator
    {
        public override Green CultivateGreen()
        {
            return new Dill
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteMn(),
                WriteCr(),
                WriteCo()
                );
        }
        protected double WriteMn()
        {
            Console.WriteLine("Введите количество марганца (г): ");
            return WriteDouble();
        }
        protected double WriteCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return WriteDouble();
        }
        protected double WriteCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return WriteDouble();
        }
    }
}
