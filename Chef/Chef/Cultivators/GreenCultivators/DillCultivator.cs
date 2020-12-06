using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.GreenCultivators
{
    class DillCultivator : GreenCultivator
    {
        public override Vegetables.Greens.Green CultivateGreen()
        {
            return new Vegetables.Greens.Dill
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
