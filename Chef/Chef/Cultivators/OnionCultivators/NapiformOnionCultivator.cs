using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.OnionCultivators
{
    class NapiformOnionCultivator : OnionCultivator
    {
        public override Vegetables.Onions.Onion CultivateOnion()
        {
            return new Vegetables.Onions.NapiformOnion
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
