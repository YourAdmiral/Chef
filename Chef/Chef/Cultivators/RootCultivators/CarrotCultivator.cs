using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.RootCultivators
{
    internal class CarrotCultivator : RootCultivator
    {
        public override Vegetables.Roots.Root CultivateRoot()
        {
            return new Vegetables.Roots.Carrot
                (
                WriteSort(),
                WriteColor(),
                WriteWeight(),
                WriteProteins(),
                WriteFats(),
                WriteCarbohydrates(),
                WriteCalories(),
                WriteWater(),
                WriteSi(),
                WriteMo(),
                WriteCo()
                );
        }
        protected double WriteSi()
        {
            Console.WriteLine("Введите количество кремния (г): ");
            return WriteDouble();
        }
        protected double WriteMo()
        {
            Console.WriteLine("Введите количество молибдена (г): ");
            return WriteDouble();
        }
        protected double WriteCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return WriteDouble();
        }
    }
}
