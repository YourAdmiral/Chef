using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.FetusCultivators
{
    internal class CucumberCultivator : FetusCultivator
    {
        public override Vegetables.Fetuses.Fetus CultivateFetus()
        {
            return new Vegetables.Fetuses.Cucumber
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteK(),
                WriteSi(),
                WriteCr()
                );
        }
        protected double WriteK()
        {
            Console.WriteLine("Введите количество калия (г): ");
            return WriteDouble();
        }
        protected double WriteSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return WriteDouble();
        }
        protected double WriteCr()
        {
            Console.WriteLine("Введите количество хрома (г): ");
            return WriteDouble();
        }
    }
}
