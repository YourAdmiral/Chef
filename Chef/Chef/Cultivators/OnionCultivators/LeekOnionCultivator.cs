using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.OnionCultivators
{
    class LeekOnionCultivator : OnionCultivator
    {
        public override Vegetables.Onions.Onion CultivateOnion()
        {
            return new Vegetables.Onions.LeekOnion
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
                WriteZn()
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
        protected double WriteZn()
        {
            Console.WriteLine("Введите количество цинка (г): ");
            return WriteDouble();
        }
    }
}
