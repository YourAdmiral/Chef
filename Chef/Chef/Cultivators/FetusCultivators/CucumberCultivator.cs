using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Fetuses;

namespace Chef.Cultivators.FetusCultivators
{
    internal class CucumberCultivator : FetusCultivator
    {
        public override Fetus CultivateFetus()
        {
            return new Cucumber
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
