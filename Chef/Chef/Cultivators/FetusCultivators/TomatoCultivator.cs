using System;
using System.Collections.Generic;
using System.Text;

namespace Chef.Cultivators.FetusCultivators
{
    class TomatoCultivator : FetusCultivator
    {
        public override Vegetables.Fetuses.Fetus CultivateFetus()
        {
            return new Vegetables.Fetuses.Tomato
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
                WriteC(),
                WriteSi()
                );
        }
        protected double WriteCo()
        {
            Console.WriteLine("Введите количество оксида углерода (г): ");
            return WriteDouble();
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
    }
}
