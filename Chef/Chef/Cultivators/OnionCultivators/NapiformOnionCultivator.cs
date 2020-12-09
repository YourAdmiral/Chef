using System;
using System.Collections.Generic;
using System.Text;
using Chef.Vegetables.Onions;

namespace Chef.Cultivators.OnionCultivators
{
    internal class NapiformOnionCultivator : OnionCultivator
    {
        public override Onion CultivateOnion()
        {
            return new NapiformOnion
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteCo(),
                WriteSi(),
                WriteC()
                );
        }
        protected double WriteCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return WriteDouble();
        }
        protected double WriteSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return WriteDouble();
        }
        protected double WriteC()
        {
            Console.WriteLine("Введите количество углерода (г): ");
            return WriteDouble();
        }
    }
}
