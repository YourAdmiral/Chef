using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Fetuses;

namespace Chef.Cultivators.FetusCultivators
{
    internal class PepperCultivator : FetusCultivator
    {
        public override Fetus CultivateFetus()
        {
            return new Pepper
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteC(),
                WriteSi(),
                WriteCu()
                );
        }
        protected double WriteC()
        {
            Console.WriteLine("Введите количество углерода (г): ");
            return WriteDouble();
        }
        protected double WriteSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return WriteDouble();
        }
        protected double WriteCu()
        {
            Console.WriteLine("Введите количество меди (г): ");
            return WriteDouble();
        }
    }
}
